﻿//----------------------------------------------------------------------
//
// Copyright (c) Microsoft Corporation.
// All rights reserved.
//
// This code is licensed under the MIT License.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files(the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and / or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions :
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//------------------------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.Identity.Client;

namespace Test.MSAL.NET.Unit
{
    class TestConstants
    {
        public static readonly SortedSet<string> Scope = new SortedSet<string>(new[] {"r1/scope1", "r1/scope2"});
        public static readonly SortedSet<string> ScopeForAnotherResource = new SortedSet<string>(new[] { "r2/scope1", "r2/scope2" });
        public static readonly string AuthorityHomeTenant = "https://login.microsoftonline.com/home/";
        public static readonly string AuthorityGuestTenant = "https://login.microsoftonline.com/guest/";
        public static readonly string AuthorityCommonTenant = "https://login.microsoftonline.com/common/";
        public static readonly string ClientId = "client_id";
        public static readonly string UniqueId = "unique_id";
        public static readonly string DisplayableId = "displayable@id.com";
        public static readonly string HomeObjectId = "home_oid";
        public static readonly string Policy = "policy";
        public static readonly string RedirectUri = "urn:ietf:wg:oauth:2.0:oob";
        public static readonly string ClientSecret = "client_secret";
        public static readonly ClientCredential CredentialWithSecret = new ClientCredential(ClientSecret);
        public static readonly User User = new User
        {
            UniqueId = UniqueId,
            DisplayableId = DisplayableId,
            HomeObjectId = HomeObjectId
        };
        
        public static readonly string OnPremiseAuthority = "https://fs.contoso.com/adfs/";
        public static readonly string OnPremiseClientId = "on_premise_client_id";
        public static readonly string OnPremiseUniqueId = "on_premise_unique_id";
        public static readonly string OnPremiseDisplayableId = "displayable@contoso.com";
        public static readonly string FabrikamDisplayableId = "displayable@fabrikam.com";
        public static readonly string OnPremiseHomeObjectId = OnPremiseUniqueId;
        public static readonly string OnPremisePolicy = "on_premise_policy";
        public static readonly string OnPremiseRedirectUri = "urn:ietf:wg:oauth:2.0:oob";
        public static readonly string OnPremiseClientSecret = "on_premise_client_secret";
        public static readonly ClientCredential OnPremiseCredentialWithSecret = new ClientCredential(ClientSecret);
        public static readonly User OnPremiseUser = new User
        {
            UniqueId = OnPremiseUniqueId,
            DisplayableId = OnPremiseDisplayableId,
            HomeObjectId = OnPremiseHomeObjectId
        };
    }
}
