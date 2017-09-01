# C# Registry Wrapper
This is an capsulation code to use Microsoft.Win32.Registry easily. It is based on two purposes.

 - To treat registry key as a property
 - To reduce code writting

 It store all data as string, and restore it using the parsor of each types. And I used dynamic value to omit type casting. This strategy costs resource but make the code shorter.
 
 The name of registry key equals the name of the property. All keys should be in a same subkey.

 ## The Usage

~~1. Copy Reg class to your project~~

~~2. Modify rootKey in the constructor.~~

~~3. Make your own properties~~

~~3.1 Make another copy of the example property.~~

~~3.1 Modify the type, the name, and the defaultValue as you wish.~~

~~3.3 CTRL + M + O to collapse all.~~
   
 Just see the 'Reg.cs' and 'Example.cs'. It is very easily understood.
