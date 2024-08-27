# Solution Structure Documentation
## Directories
At the root is the main .gitignore file.  This is in order to just clear out all VS Code and Visual Studio type references.  I used CoPilot to come up with a basic list of patterns to exclude.  Originally I had started to just do it myself and realized that is not a smart way of doing it.  

/src/* This is the directory that maintains all of the source code for the Solution and the project.  At the root of this folder is the Solution file.  

There are two directories under /src : 

* Libraries - This is used to store any class library projects which are to be used.  I can see in the future, where I may want to construct these in a particular manner.  Each libary project is inside it's own folder so that they are easily portable.
* Tests - These are where the Test Libraries are held.  I had the hardest time creating a test project due to some cached offline nuget packages.  In my Visual Studio instance, I did add a new source for nuget, pointing to it's v3 feed.  I should probably put that inot a nuget.config file at the root of the src, so that any engineer besides me can pick it up.  However, since I am the only one developing it, I am passing.

/documentation/* This is where all documentation will be stored.  I am just going to also think a little deeper here on what to add.  Eventually I should add like release documentation as well as other actions like github actions.