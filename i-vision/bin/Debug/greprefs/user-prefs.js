//UPDATED: This first preference can be set by code to allow your application to be copied/moved to another directory
//and still maintain the correct path to the initialization file.
//user_pref("capability.principal.myapp.id", "file:///C:/path/to/initializationfile.html");

//This preference MUST be set in user-prefs.js
user_pref("capability.principal.myapp.granted", "UniversalXPConnect");