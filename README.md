# docfx

Learning DocFX

## Running in Linux

Steps:

* Install Mono.
* Download docfx.zip from the [docfx releases page](https://github.com/dotnet/docfx/releases).
* Extract contents of docfx.zip.  (I put mine in ~/bin/docfx)
* Add extraction folder to your path, e.g., `export PATH="$HOME/bin/docfx:$PATH"`, in .profile.
* You'll be using mono to launch docfx, so while you're in .profile, you can add an alias to make this easier:  `alias docfx='mono ~/bin/docfx/docfx.exe'`
* Save .profile and reload it: `source .profile`.  (You'll need to restart your session to make this permanent.)

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
