DOCFXCMD = docfx
SERVERPORT = 8080
WEBFILEFOLDER = _site

default:
	@echo 'Targets:'
	@echo '  srv-b  ->  Serve with built-in webserver'
	@echo '  srv-p  ->  Serve with PHP dev webserver'
	@echo '  build  ->  Build documentation'
	@echo '  clean  ->  Remove build output'

srv-b:
	$(DOCFXCMD) serve $(WEBFILEFOLDER) -p $(SERVERPORT)

srv-p:
	php -S localhost:$(SERVERPORT) -t $(WEBFILEFOLDER)

build:
	$(DOCFXCMD) metadata
	$(DOCFXCMD) build -f

clean:
	@rm -rf obj/
	@echo 'Removed obj/'
	@rm -rf $(WEBFILEFOLDER)/
	@echo 'Removed $(WEBFILEFOLDER)/'
