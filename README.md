** 1. 修改AccountSettings.cs中的参数为IDP对应参数。其中证书为 idp metadata 中的签名X509Certificate内容**

** 2. 将 AppSettings.cs 中的参数告诉IDP用来配置**

This project was a proof of concept, not recommended to use it in production environments since it not cover all security checks that SAML demand.

Onelogin's is working on the release of a new toolkit for .NET, but it gonna take time, meanwhile, if you need  a .NET SAML toolkit, We can suggest some alternatives:
- [ComponentSpace](http://www.componentspace.com/) (commercial)
- [OIOSAML](https://digitaliser.dk/resource/2972745) (open source)
- [ITfoxtec](http://itfoxtec.com/identitysaml2) (open source)
- [Sustainsys](https://github.com/Sustainsys/Saml2) (formerly Kentor) (open source)
- [Owin.Security.Saml](https://github.com/elerch/SAML2) (open source)
