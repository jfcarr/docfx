# docfx

Learning DocFX

## Running in Linux

I prefer to work in Linux.  :-)

Steps:

* Install Mono.
* Download docfx.zip from the [docfx releases page](https://github.com/dotnet/docfx/releases).
* Extract contents of docfx.zip.  (I put mine in ~/bin/docfx-bin)
* Add extraction folder to your path, e.g., `export PATH="$HOME/bin/docfx-bin:$PATH"`, in .profile.
* Save .profile and reload it: `source .profile`.  (You'll need to restart your session to make this permanent.)

Since we're using Mono to launch DocFX, you may want to set up a bash script with a symbolic link to make this easier:

* `cd ~/bin`
* `vi docfx.sh`  (Use a different editor if you prefer.)
* Add lines:
```
#!/bin/bash

mono $HOME/bin/docfx-bin/docfx.exe $*
```
* Save and exit
* Add a symbolic link: `ln -s ~/bin/docfx.sh docfx`

Verify that everything's set up correctly:

```
docfx help
```

Should show a message similar to this:

```
docfx 2.40.12.0
Copyright (C) 2019 © Microsoft Corporation. All rights reserved.
This is open-source software under MIT License.
   Usage1: docfx <docfx.json file path> [-o <output folder path>]
   Usage2: docfx <subcommand> [<args>]


See 'docfx help <command> to read about a specific subcommand guide

    build           : Generate client-only website combining API in YAML files and conceptual files
    dependency      : Export dependency file
    download        : Download remote xref map file and create an xref archive in local.
    help            : Get an overall guide for the command and sub-commands
    init            : Generate an initial docfx.json following the instructions
    merge           : Merge .net base API in YAML files and toc files.
    metadata        : Generate YAML files from source code
    pdf             : Generate pdf file
    serve           : Host a local static website
    template        : List or export existing template
```
