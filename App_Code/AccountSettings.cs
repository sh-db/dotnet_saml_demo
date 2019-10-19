using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// AccountSettings
/// 
/// Replace this class with an interface to your own applications account settings. 
/// 
/// Each account should as a minimum have the following:
///  - A URL pointing to the identity provider for sending Auth Requests
///  - A X.509 certificate for validating the SAML Responses from the identity provider
/// 
/// These should be retrieved from the account store/database on each request in the authentication flow.
/// by sbin@
/// </summary>
public class AccountSettings
{
    public string certificate = "MIIC4DCCAcigAwIBAgIQVOSOTuV016lJyI4hXAt9SDANBgkqhkiG9w0BAQsFADAsMSowKAYDVQQDEyFBREZTIFNpZ25pbmcgLSBhZGZzLXNydi5zZGIwMS5jb20wHhcNMTkwODE1MDQwMzQxWhcNMjAwODE0MDQwMzQxWjAsMSowKAYDVQQDEyFBREZTIFNpZ25pbmcgLSBhZGZzLXNydi5zZGIwMS5jb20wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDtli3YeOweUabl63xsndQowBEmB6zA9D0EqY0Gr41wZ9yArByp0EOHSfuTH7ZXOHGpP/qmrb+1CTETrtwJhTAkVKsSxsPgOlnUlpUJBD+w7T+TnbIhiOZyXHMb7+nTpIVLnY1zPrZUHDhq1y2By6HE3qZXIBawiT2tTt1earZBgMso8GiPF4DOUVMPg2jtUM21urvch+6ucRXv17QRK1CLf9yyvA16uMmTIbPccJhlWXEX+SJ3tOYBWtyVCmuq9uM/zZVPq1eLX5SKXmoMgR577vnCy+7xjfOJCkLMLbM+u8pM6SFlFB1BzvWajZ1O+BgxRvwwCFSTWxgo5kRnqgKBAgMBAAEwDQYJKoZIhvcNAQELBQADggEBAB8xAOPVep1QtL/jKQ4XiKIivvVYuEk/ilP0MoMGm9gR8v5AbegaCF2jMi6I9Li2Z3t3he1FxvSGuYSuvNcHb6zenERPB9ZhJNoDOo4Yhar3iLwJe9QaQYRngultyHko/yy+oahCwjHeFbznWJ6rEVSVBvauutpCsYvZCsALdyQGQWEsC1+9RAyDHtYm+ZmEiOXBMyYXbiMP9d4oXsdQ3mqj9y4+T0j3LP51+HASl9ps4k1wcoiWK18WbTP3V/Aw2mPEsG8pa9FHLbFCmeHk5J+yPJasw9FV/k66i8VpJY1n6EfGAkC0arqZaq8S91yHoXEkkcXT7twREWpX1uURblM=";
    public string idp_sso_target_url = "https://adfs-srv.sdb01.com/adfs/ls/";
}
