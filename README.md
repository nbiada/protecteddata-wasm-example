# ProtectedData Example
Example of `ProtectedData` attributes for Blazor WASM project.

## Description
This application demonstrates the use of the `ProtectedPersonalData` data annotation and the __Microsoft Identity Protector System__  

The Microsoft Identity Protector System, via interfaces implementations, allow the developer to protect (crypt) and unprotect (decrypt) the _Personal Data_ in the AspNetUsers table.  



From original question by [Andrea Petrelli](https://github.com/Andrea-Perelli) on 
[Stackoverflow](https://stackoverflow.com/questions/68828951/how-to-use-protectedpersonaldata-attribute/68831681?noredirect=1#comment121666585_68831681)


## How to
Register a new user and look at the database fields of the __AspNetUsers__ table.

The __ProtectorExtensions.cs__ source file contains an example of the _Protect / Unprotect_ functions.
