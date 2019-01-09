import { AuthConfig } from 'angular-oauth2-oidc';

export const ImplicitFlowConfig: AuthConfig = {

  // Url of the Identity Provider
  issuer: 'http://localhost:5000',

  loginUrl: 'http://localhost:5000/connect/authorize',

  // URL of the SPA to redirect the user to after login
  //redirectUri: 'http://localhost:8100/signin-oidc',
  redirectUri: 'http://localhost:8100/index.html',

  postLogoutRedirectUri: 'http://localhost:8100',

  responseType: 'code id_token',

  requireHttps: false,

  // The SPA's id. The SPA is registerd with this id at the auth-server
  clientId: 'imp.client',

  // set the scope for the permissions the client should request
  // The first three are defined by OIDC. The 4th is a usecase-specific one
  scope: 'openid profile api1',
}
