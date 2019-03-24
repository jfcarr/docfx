BROWSER = firefox

default:
	@echo 'Targets:'
	@echo '  view'
	@echo '  build'
	@echo '  clean'

view:
	$(BROWSER) _site/index.html

build:
	docfx build -t statictoc

clean:
	rm -rf obj/
	rm -rf _site/
