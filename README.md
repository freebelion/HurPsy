# HurPsy
The projects in this group are intended to result in
easy-to-use applications which will help design and run
psychology experiments on computer screens.

The projects are:

+ **HurPsyLib** class library is a collection of classes
which represent experiments and parts and objects
that make up experiments.<br>
They are utilized in the GUI-based experiment design
applications found in this group,
but they can also be incorporated into other design programs
or visual applications specifically created for single experiments.


+ **HurPsyExp** is a WPF-based desktop application
which will help design and run experiments by utilizing
the **HurPsyLib** library classes.
It is being developed to perfect the visual interface
which will eventually be used in a cross-platform
design application based on .NET Maui.
This final step may have to be developed as a properietary
application, because it will require developer
licenses for multiple platforms.<br>
This project contains two inner namespaces:

  - **ExpDesign** namespace contains view and viewmodel
  classes which are used in the interface
  which will help design, save and load experiment.
  - **ExpRun** namespace contains view and viewmodel
  classes which are used in the interface
  which will help run experiments saved in files.

  Both these namespaces make use of the Community Mvvm toolkit
  to simplify writing the viewmodel classes.

+ **HurPsyLibStrings** is a separate project containing
only a `.resx` resource file with message/error strings 
used in **HurPsyLib** library classes.<br>
> It is created as a separate project to make localization easier
for international developers.

+ **HurPsyExpStrings** is a separate project containing
only a `.resx` resource file with message/error/label strings 
used in views and viewmodel classes of the **HurPsyExp** project.<br>
> It is created as a separate project to make localization easier
for international developers.

All these projects' class definitions, their members, properties,
functions and methods have been explained in their respective
XML comments.<br>
Those XML comments have then been converted into `.md` markdown files
in **Documentation** folders of individual projects
by the NuGet package [**DefaultDocumentation**](https://www.nuget.org/packages/DefaultDocumentation/).

Anyone interested in the current status and future directions
of this group of projects, please write in the
**Discussions** section of the Github repository.
