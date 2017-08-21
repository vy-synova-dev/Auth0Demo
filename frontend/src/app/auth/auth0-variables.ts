interface AuthConfig {
  clientID: string;
  domain: string;
  callbackURL: string;
  apiUrl: string;
}

export const AUTH_CONFIG: AuthConfig = {
  clientID: 'favi5MDu4TW6VWTiDFmJB3OkFY93Ef5T',
  domain: 'vynguyen.eu.auth0.com',
  callbackURL: 'http://localhost:4200/callback',
  apiUrl: 'https://thisismyapi.com'
};
