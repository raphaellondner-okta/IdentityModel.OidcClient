﻿using IdentityModel.Client;

namespace IdentityModel.OidcClient
{
    class ResponseValidationResult : Result
    {
        public AuthorizeResponse AuthorizeResponse { get; set; }
        public TokenResponse TokenResponse { get; set; }
        public Claims Claims { get; set; }
    }
}