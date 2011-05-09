
public enum ss_error_code {
    STREAM_ERROR_NONE                                                = 0,
    STREAM_ERROR_PARAMETER                                           = 1,
    STREAM_ERROR_PARAMETER_NOT_UINT32                                = 2,
    STREAM_ERROR_PARAMETER_NOT_UINT32_RANGE                          = 3,
    STREAM_ERROR_PARAMETER_NOT_BOOLEAN                               = 4,
    STREAM_ERROR_PARAMETER_NOT_HEX                                   = 5,
    STREAM_ERROR_MEMORY_ALLOCATION                                   = 6,
    STREAM_ERROR_PARSE                                               = 7,
    STREAM_ERROR_READ                                                = 8,
    STREAM_ERROR_WRITE                                               = 9,
    STREAM_ERROR_END_WRITE                                           = 10,
    STREAM_ERROR_END_READ                                            = 11,
    STREAM_ERROR_NOT_IMPLEMENTED                                     = 12,
    STREAM_ERROR_WOULD_BLOCK                                         = 13,
    STREAM_ERROR_GENERATE_RANDOM                                     = 14,
    STREAM_ERROR_INIT_RANDOM                                         = 15,
    STREAM_ERROR_SEED_RANDOM                                         = 16,
    STREAM_ERROR_CREATE_RANDOM_OBJECT                                = 17,
    STREAM_ERROR_SHUTTING_DOWN                                       = 18,
    STREAM_ERROR_DEQUEUING_CONNECTION                                = 19,
    STREAM_ERROR_SECURE_CERTIFICATE_ROOT                             = 20,
    STREAM_ERROR_SECURE_CERTIFICATE_COMPANY_NAME                     = 21,
    STREAM_ERROR_SECURE_CERTIFICATE_NOT_TRUSTED                      = 24,
    STREAM_ERROR_SECURE_DUPLICATE_CONTEXT                            = 25,
    STREAM_ERROR_SECURE_SET_IO                                       = 26,
    STREAM_ERROR_SECURE_CERTIFICATE_FILE_NOT_FOUND                   = 33,
    STREAM_ERROR_SECURE_READ_CERTIFICATE                             = 34,
    STREAM_ERROR_SECURE_READ_PRIVATE_KEY                             = 35,
    STREAM_ERROR_SECURE_SET_PRIVATE_KEY                              = 36,
    STREAM_ERROR_SECURE_CERTIFICATE_EXPIRY_DATE                      = 37,
    STREAM_ERROR_SECURE_EXPORT_CERTIFICATE                           = 38,
    STREAM_ERROR_SECURE_ADD_CERTIFICATE                              = 39,
    STREAM_ERROR_SECURE_TRUSTED_CERTIFICATE_FILE_NOT_FOUND           = 40,
    STREAM_ERROR_SECURE_TRUSTED_CERTIFICATE_READ                     = 41,
    STREAM_ERROR_SECURE_CERTIFICATE_COUNT                            = 42,
    STREAM_ERROR_SECURE_CREATE_CERTIFICATE                           = 43,
    STREAM_ERROR_SECURE_IMPORT_CERTIFICATE                           = 44,
    STREAM_ERROR_SECURE_ADD_TRUSTED_CERTIFICATE                      = 48,
    STREAM_ERROR_SECURE_CREATE_PRIVATE_KEY_OBJECT                    = 49,
    STREAM_ERROR_SECURE_CERTIFICATE_EXPIRED                          = 50,
    STREAM_ERROR_SECURE_CERTIFICATE_COMPANY_UNIT                     = 51,
    STREAM_ERROR_SECURE_CERTIFICATE_COMMON_NAME                      = 52,
    STREAM_ERROR_SECURE_HANDSHAKE                                    = 53,
    STREAM_ERROR_HTTP_VERSION                                        = 54,
    STREAM_ERROR_SOCKET_HOST_NAME_NOT_FOUND                          = 57,
    STREAM_ERROR_SOCKET_CREATE_TCPIP                                 = 58,
    STREAM_ERROR_SOCKET_CREATE_UDP                                   = 59,
    STREAM_ERROR_SOCKET_BIND                                         = 60,
    STREAM_ERROR_SOCKET_CLEANUP                                      = 61,
    STREAM_ERROR_SOCKET_CLOSE                                        = 62,
    STREAM_ERROR_SOCKET_CONNECT                                      = 63,
    STREAM_ERROR_SOCKET_GET_NAME                                     = 64,
    STREAM_ERROR_SOCKET_GET_OPTION                                   = 65,
    STREAM_ERROR_SOCKET_SET_OPTION                                   = 66,
    STREAM_ERROR_SOCKET_LISTEN                                       = 67,
    STREAM_ERROR_SOCKET_SHUTDOWN                                     = 68,
    STREAM_ERROR_SOCKET_SELECT                                       = 69,
    STREAM_ERROR_SOCKET_STARTUP                                      = 70,
    STREAM_ERROR_SOCKET_LOCALHOST_NAME_NOT_FOUND                     = 71,
    STREAM_ERROR_SOCKET_GET_HOST_BY_ADDR                             = 72,
    STREAM_ERROR_LOAD_NETWORK_LIBRARY                                = 73,
    STREAM_ERROR_SOCKET_PORT_OUT_OF_RANGE                            = 74,
    STREAM_ERROR_ACTSYNC_NO_PORT                                     = 75,
    STREAM_ERROR_ACTSYNC_NOT_INSTALLED                               = 76,
    STREAM_ERROR_HTTP_CONTENT_TYPE_NOT_SPECIFIED                     = 77,
    STREAM_ERROR_HTTP_CLIENT_ID_NOT_SET                              = 78,
    STREAM_ERROR_HTTP_BUFFER_SIZE_OUT_OF_RANGE                       = 79,
    STREAM_ERROR_HTTP_EXTRA_DATA_END_READ                            = 80,
    STREAM_ERROR_HTTP_CRLF_ENCODED_MISSING                           = 81,
    STREAM_ERROR_HTTP_CRLF_MISSING                                   = 82,
    STREAM_ERROR_HTTP_NO_CONTD_CONNECTION                            = 83,
    STREAM_ERROR_HTTP_CHUNK_LEN_ENCODED_MISSING                      = 84,
    STREAM_ERROR_HTTP_CHUNK_LEN_BAD_CHARACTER                        = 85,
    STREAM_ERROR_HTTP_BAD_STATUS_CODE                                = 86,
    STREAM_ERROR_HTTP_UNKNOWN_TRANSFER_ENCODING                      = 87,
    STREAM_ERROR_HTTP_UNABLE_TO_PARSE_COOKIE                         = 88,
    STREAM_ERROR_HTTP_EXPECTED_POST                                  = 89,
    STREAM_ERROR_SOCKET_LIVENESS_OUT_OF_RANGE                        = 200,
    STREAM_ERROR_READ_TIMEOUT                                        = 201,
    STREAM_ERROR_WRITE_TIMEOUT                                       = 202,
    STREAM_ERROR_DUN_NOT_SUPPORTED                                   = 203,
    STREAM_ERROR_DUN_DIAL_FAILED                                     = 204,
    STREAM_ERROR_SECURE_NO_SERVER_CERTIFICATE                        = 205,
    STREAM_ERROR_SECURE_NO_SERVER_CERTIFICATE_PASSWORD               = 206,
    STREAM_ERROR_SECURE_NO_TRUSTED_ROOTS                             = 207,
    STREAM_ERROR_SECURE_REDUNDANT_SERVER_CERTIFICATE_PASSWORD        = 208,
    STREAM_ERROR_HTTP_AUTHENTICATION_REQUIRED                        = 209,
    STREAM_ERROR_HTTP_PROXY_AUTHENTICATION_REQUIRED                  = 210,
    STREAM_ERROR_HTTP_AUTHENTICATION_FAILED                          = 211,
    STREAM_ERROR_HTTP_PROXY_AUTHENTICATION_FAILED                    = 212,
    STREAM_ERROR_HTTP_NO_USERID                                      = 213,
    STREAM_ERROR_HTTP_NO_PASSWORD                                    = 214,
    STREAM_ERROR_HTTP_UNSUPPORTED_AUTH_ALGORITHM                     = 215,
    STREAM_ERROR_HTTP_HEADER_PARSE_ERROR                             = 216,
    STREAM_ERROR_HTTP_SERVER_AUTH_FAILED                             = 217,
    STREAM_ERROR_INTERRUPTED                                         = 218,
    STREAM_ERROR_HTTP_INVALID_CHARACTER                              = 219,
    STREAM_ERROR_INTERNAL                                            = 220,
    STREAM_ERROR_SECURE_OPEN_SYSTEM_CERT_STORE                       = 221,
    STREAM_ERROR_SECURE_IMPORT_CERT_FROM_SYSTEM_STORE                = 222,
    STREAM_ERROR_SECURE_NO_CERTS_IN_SYS_STORE                        = 223,
    STREAM_ERROR_LOAD_LIBRARY_FAILURE                                = 224,
    STREAM_ERROR_LIBRARY_ENTRY_POINT_NOT_FOUND                       = 225,
    STREAM_ERROR_INVALID_SYNC_PROTOCOL                               = 226,
    STREAM_ERROR_INTERNAL_PROTOCOL_NOT_LOADED                        = 227,
    STREAM_ERROR_SERVER_ERROR                                        = 228,
    STREAM_ERROR_MISSING_PARAMETER                                   = 229,
    STREAM_ERROR_COULD_NOT_OPEN_FILE_FOR_WRITE                       = 230,
    STREAM_ERROR_PROTOCOL_ERROR                                      = 231,
    STREAM_ERROR_INVALID_COMPRESSION_TYPE                            = 232,
    STREAM_ERROR_VALUE_OUT_OF_RANGE                                  = 233,
    STREAM_ERROR_UNEXPECTED_HTTP_REQUEST_TYPE                        = 234,
    STREAM_ERROR_HTTP_MALFORMED_SESSION_COOKIE                       = 235,
    STREAM_ERROR_HTTP_INTERNAL_HEADER_STATE                          = 236,
    STREAM_ERROR_HTTP_INTERNAL_REQUEST_TYPE                          = 237,
    STREAM_ERROR_INTERNAL_API                                        = 238,
    STREAM_ERROR_NO_ECC_FIPS                                         = 239,
    STREAM_ERROR_UNRECOGNIZED_TLS_TYPE                               = 240,
    STREAM_ERROR_CONNECT_TIMEOUT                                     = 241,
    STREAM_ERROR_INCONSISTENT_FIPS                                   = 242,
    STREAM_ERROR_INVALID_LOCAL_PATH                                  = 243,
    STREAM_ERROR_HTTP_INVALID_SESSION_KEY                            = 244,
    STREAM_ERROR_INVALID_NETWORK_LIBRARY                             = 245,
    STREAM_ERROR_NETWORK_LIBRARY_VERSION_MISMATCH                    = 248,
    STREAM_ERROR_AUTHENTICATION_FAILED                               = 249,
    STREAM_ERROR_SACI_IMPLEMENTATION_MISMATCH                        = 250,
    STREAM_ERROR_E2EE_UNKNOWN_PUBLIC_KEY_ENC_TYPE                    = 251,
    STREAM_ERROR_E2EE_UNEXPECTED_PUBLIC_KEY_ENC_TYPE                 = 252,
    STREAM_ERROR_E2EE_MISMATCHED_KEYS                                = 253,
    STREAM_ERROR_E2EE_UNEXPECTED_PRIVATE_KEY_TYPE                    = 254,
    STREAM_ERROR_E2EE_READING_PRIVATE_KEY                            = 255,
    STREAM_ERROR_E2EE_NO_PRIVATE_KEY_IN_FILE                         = 256,
    STREAM_ERROR_E2EE_DECODING_PRIVATE_KEY_FILE                      = 257,
    STREAM_ERROR_E2EE_READING_PRIVATE_KEY_FILE                       = 258,
    STREAM_ERROR_E2EE_MISSING_PRIVATE_KEY_PASSWORD                   = 259,
    STREAM_ERROR_E2EE_MISSING_PRIVATE_KEY                            = 260,
    STREAM_ERROR_E2EE_INVALID_TYPE                                   = 261,
    STREAM_ERROR_E2EE_INIT_ECC                                       = 262,
    STREAM_ERROR_E2EE_PUBLIC_KEY                                     = 263,
    STREAM_ERROR_COULD_NOT_OPEN_FILE                                 = 264,
    STREAM_ERROR_HTTP_UNKNOWN_SESSION                                = 265,
    STREAM_ERROR_SACI_ERROR                                          = 266,
    STREAM_ERROR_HTTP_FAILED_READING_HEADERS                         = 277,
    STREAM_ERROR_HTTP_BAD_REQUEST                                    = 278,
    STREAM_ERROR_CONNECTION_ABANDONED                                = 279,
    STREAM_ERROR_LAST                                                = 0x7FFF
};

public enum UL_RESULTSET_STATE {
    ERROR = -1,	///< Error.
    UNPREPARED = 0,	///< Not prepared.
    ON_ROW,		///< On a valid row.
    BEFORE_FIRST,	///< Before the first row.
    AFTER_LAST,	///< After the last row.
    COMPLETED	///< Closed.
};

/** Specifies values that control how a column name is retrieved when
 * describing a result set.
 * \see ULResultSetSchema::GetColumnName
 */
public enum ul_column_name_type {
    /// For SELECT statements, return the alias or correlation name.  For tables,
    /// return the column name.
    ul_name_type_sql,
    /// For SELECT statements, return the alias or correlation name and exclude
    /// any table names that were specified.  For tables, return the column name.
    ul_name_type_sql_column_only,
    /// Return the underlying table name if it can be determined.  If the
    /// table does not exist in the database schema, an empty string is returned.
    ul_name_type_base_table,
    /// Return the underlying column name if it can be determined.  If the
    /// column does not exist in the database schema, an empty string is returned.
    ul_name_type_base_column,
    /// \internal
    ul_name_type_base
};

/** Represents the host variable types for a column.
 *
 * These values are used to identify the host variable type required for a
 * column, and to indicate how UltraLite should fetch values.
 */
public enum ul_column_storage_type {
    UL_TYPE_BAD_INDEX,		///< Invalid value
    UL_TYPE_S_LONG,		///< ul_s_long (32 bit signed int)
    UL_TYPE_U_LONG,		///< ul_u_long (32 bit unsigned int)
    UL_TYPE_S_SHORT,		///< ul_s_short (16 bit signed int)
    UL_TYPE_U_SHORT,		///< ul_u_short (16 bit unsigned int)
    UL_TYPE_S_BIG,		///< ul_s_big (64 bit signed int)
    UL_TYPE_U_BIG,		///< ul_u_big (64 bit unsigned int)
    UL_TYPE_TINY,		///< ul_byte (8 bit unsigned)
    UL_TYPE_BIT,		///< ul_byte (8 bit unsigned, 1 bit used)
    UL_TYPE_DOUBLE,		///< ul_double (double)
    UL_TYPE_REAL,		///< ul_real (float)
    UL_TYPE_BINARY,		///< ul_binary (2 byte length followed by byte array)
    UL_TYPE_TIMESTAMP_STRUCT,	///< DECL_DATETIME
    UL_TYPE_TCHAR,		///< character array (string buffer)
    UL_TYPE_CHAR,		///< char array (string buffer)
    UL_TYPE_WCHAR,		///< ul_wchar (UTF16) array
    UL_TYPE_GUID,		///< GUID structure
    UL_TYPE_NULL,		///< \internal
    UL_TYPE_SIZED_BINARY,	///< \internal
    UL_TYPE_MAX_INDEX		///< \internal
};

/** Represents the SQL types for a column.
 * 
 * These values correspond to SQL column types.
 */
public enum ul_column_sql_type {
    /// The column at the specified index does not exist.
    UL_SQLTYPE_BAD_INDEX,
    /// The column contains a signed long.
    UL_SQLTYPE_S_LONG,
    /// The column contains an unsigned long.
    UL_SQLTYPE_U_LONG,
    /// The column contains a signed short.
    UL_SQLTYPE_S_SHORT,
    /// The column contains an unsigned short.
    UL_SQLTYPE_U_SHORT,
    /// The column contains a signed 64-bit integer.
    UL_SQLTYPE_S_BIG,
    /// The column contains an unsigned 64-bit integer.
    UL_SQLTYPE_U_BIG,
    /// The column contains an unsigned 8-bit integer.
    UL_SQLTYPE_TINY,
    /// The column contains a 1-bit flag.
    UL_SQLTYPE_BIT,
    /// The column contains timestamp information.
    UL_SQLTYPE_TIMESTAMP,
    /// The column contains date information.
    UL_SQLTYPE_DATE,
    /// The column contains time information.
    UL_SQLTYPE_TIME,
    /// The column contains a double precision floating-point number. (8 bytes)
    UL_SQLTYPE_DOUBLE,
    /// The column contains a single precision floating-point number. (4 bytes)
    UL_SQLTYPE_REAL,
    /// The column contains exact numerical data, with specified precision and scale.
    UL_SQLTYPE_NUMERIC,
    /// The column contains binary data with a specified maximum length.
    UL_SQLTYPE_BINARY,
    /// The column contains character data with a specified length.
    UL_SQLTYPE_CHAR,
    /// The column contains character data with variable length.
    UL_SQLTYPE_LONGVARCHAR,
    /// The column contains binary data with variable length.
    UL_SQLTYPE_LONGBINARY,
    /// The column contains a UUID.
    UL_SQLTYPE_UUID,
    /// The column contains spatial data in the form of points.
    UL_SQLTYPE_ST_GEOMETRY,
    /// The column contains timestamp and time zone information.
    UL_SQLTYPE_TIMESTAMP_WITH_TIME_ZONE,
    /// \internal
    UL_SQLTYPE_MAX_INDEX
};
