UpdateChecker
=============
A simple program to manually check for and download application updates from a remote server.

Instructions for use:
	Edit the UpdateChecker.exe.config file according to your update server configuration (see below).
		
Default configuration:
	BaseURL: http://127.0.0.1/misc/updater-test/
		This is where the remote version and update archive files will be relative to. For example,
		if the remote version file is specified as builds/version.txt, the program will look at
		<http://127.0.0.1/misc/updater-test/builds/version.txt>.
	
	VersionFile: version
		Relative to BaseURL; this is the file that resides on the webserver with the latest version
		number information.

	LocalVersionFile: version
		Relative to the application's startup path; this is the file on the local machine that contains
		the current program version number information.

	UpdateFile: update.zip
		Relative to BaseURL; this is the compressed .zip archive containing the updated program files that
		will be extracted and replace the current version of the program files. The structure of this archive
		should resemble the current version's with no additional subdirectories.
		
Copyright (C)2013 ipavl. All rights reserved.
This program makes use of the DotNetZip library.