//
//  DataAccess.mm
//  names
//
//  Created by Bruce Hill on 2011/03/07.
//  Copyright 2011 Mobility at work. All rights reserved.
//

#import "DataAccess.h"
#import "wrapper.h"

@implementation DataAccess

#define SELECT_STMT @"SELECT TOP 1 START AT %d name FROM Names ORDER BY name FOR UPDATE"

static DataAccess * sharedInstance = nil;
static Connection * connection;

- (Connection *)createDatabase:(const char *)connectionParms {
    const char *    CREATE_TABLE = 
    "CREATE TABLE Names ("
    "id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,"
    "name VARCHAR(254) NOT NULL)";
    const char *    CREATE_INDEX = 
    "CREATE UNIQUE INDEX namesIndex ON Names(name ASC)";
    const char *    createParms = 
    "page_size=4k;utf8_encoding=true;collation=UTF8BIN";
    //ULError            error;
    Connection *    conn;
	
	conn = [DatabaseManager createDatabase:connectionParms :createParms]; 
    
    //if (!conn) {
    //    NSLog(@"Error code creating the database: %ld",
    //          error.GetSQLCode());
    //} else {
        NSLog(@"Creating Schema.");
	[conn executeStatement:CREATE_TABLE];
    [conn executeStatement:CREATE_INDEX];
    //}
    return conn;
}

- (void)openConnection {
    NSLog(@"Connect to database.");
    if ([DatabaseManager initialize]) {         //ULDatabaseManager::Init()) {
        NSArray *	paths = NSSearchPathForDirectoriesInDomains(
																NSDocumentDirectory,
																NSUserDomainMask,
																YES);
        NSString *	documentsDirectory = [paths objectAtIndex:0];
        NSString *	writableDBPath = [documentsDirectory 
									  stringByAppendingPathComponent:
									  @"Names.udb"];
        Connection * conn = nil;
        const char * connectionParms;
        //ULError            error;
		
        connectionParms = [[NSString stringWithFormat:@"DBF=%@",
                            writableDBPath]
						   UTF8String];
        
        // Attempt connection to the database
		conn = [DatabaseManager openConnection: connectionParms];
    
        // If database file not found, create it and create the schema
        if (conn != nil) {       //error.GetSQLCode() == SQLE_ULTRALITE_DATABASE_NOT_FOUND) {
            conn = [self createDatabase:connectionParms];
        }
        connection = conn;
    } else {
        NSLog(@"UL Database Manager initialization failed.");
        connection = nil;
    }
}

+ (DataAccess *)sharedInstance {
    // Create a new instance if none was created yet
    if (sharedInstance == nil) {
        sharedInstance = [[super alloc] init];
        [sharedInstance openConnection];
    }
    
    // Otherwise, just return the existing instance
    return sharedInstance;
}


+ (void)fini {
    [sharedInstance release];
}

- (void)dealloc {
    NSLog(@"Finalizing DB Manager.");
	[connection close];
    [DatabaseManager fini];
    
    [super dealloc];
}

- (void)addName:(NSString *)name {
    const char * INSERT = "INSERT INTO Names(name) VALUES(?)";
    PreparedStatement * prepStmt = [connection prepareStatement:INSERT];   // ((ULConnection*)connection)->PrepareStatement(INSERT);
    
    if (prepStmt != nil) {
        // Convert the NSString to a C-Style string using UTF8 Collation
		[prepStmt setParameterString:1 :[name UTF8String] :[name length]];
        [prepStmt executeStatement];
		[prepStmt close];
		[connection commit];
    } else {
        NSLog(@"Could not prepare INSERT statement.");
    }
}

- (NSInteger) getNameCount {
	 const char * COUNT = "SELECT COUNT (*) FROM Names";
	PreparedStatement * prepStmt = [connection prepareStatement:COUNT];           //((ULConnection*)connection)->PrepareStatement(COUNT);
	 int numberOfNames = 0;
	
	 if (prepStmt != nil) {
		 ResultSet *resultSet = [prepStmt executeQuery];   // prepStmt->ExecuteQuery();
		 [resultSet first];
		 
		 numberOfNames = [resultSet getIntWithCid:1]; 
		 [resultSet close];
		 [prepStmt close];
	 } 
	 else {
	   NSLog(@"Couldn't prepare COUNT.");
	 }
	 
	 return numberOfNames;
}

- (NSString *) getName: (int) index {

    // +1 to the index since the DB uses a 1-based index rather than 0-based 
    PreparedStatement* prepStmt;
	prepStmt =  [connection prepareStatement:[[NSString stringWithFormat:SELECT_STMT, index] UTF8String]];
    if (prepStmt != nil) {
        ResultSet * resultSet = [prepStmt executeQuery];
        char name[255];
 
		[resultSet first];
		[resultSet getStringWithCname: "name": name: 255];
		[resultSet close];
		[prepStmt close];
        
		return [NSString stringWithUTF8String:name];
    } 
	else {
        NSLog(@"Couldn't prepare SELECT with index.");
		return nil;
    }
}
@end
