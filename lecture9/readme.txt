
How to manually compile lecture9.fs?

Copy lecture9.fs into the directory containing files

FsUnit.NUnit.dll
nunit.framework.dll
app.config

Compile the assembly by calling the F# compiler with the following command line

fsharpc --target:library -o lecture9.dll lecture9.fs -r FsUnit.NUnit.dll -r nunit.framework.dll

After running the command you should have 

lecture9.dll


Now copy app.config to lecture9.dll.config.

Get NUnit runners from the NUnit package:

http://launchpad.net/nunitv2/trunk/2.6.3/+download/NUnit-2.6.3.zip

Then launch

mono nunit.exe

And open the lecture9.dll as "project". You should see names of the tests defined in lecture9.fs
and should be able to run them.


