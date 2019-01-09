export var AuthPasswordFlowConfig = {
    // Url of the Identity Provider
    issuer: "http://localhost:5000",
    tokenEndpoint: "http://localhost:5000/connect/token",
    // Url with user info endpoint
    // This endpont is described by OIDC and provides data about the loggin user
    // This sample uses it, because we don't get an id_token when we use the password flow
    // If you don't want this lib to fetch data about the user (e. g. id, name, email) you can skip this line
    userinfoEndpoint: "http://localhost:5000/connect/userinfo",
    // The SPA's id. Register SPA with this id at the auth-server
    clientId: "ro.client",
    // set the scope for the permissions the client should request
    scope: "offline_access api1",
    // Set a dummy secret
    // Please note that the auth-server used here demand the client to transmit a client secret, although
    // the standard explicitly cites that the password flow can also be used without it. Using a client secret
    // does not make sense for a SPA that runs in the browser. That's why the property is called dummyClientSecret
    // Using such a dummy secret is as safe as using no secret.
    dummyClientSecret: "secret",
    showDebugInformation: true,
    oidc: false
};
//# sourceMappingURL=auth-password-flow.config.js.map