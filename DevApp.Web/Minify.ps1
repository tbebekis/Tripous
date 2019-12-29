# add a Pre-Build task as
# powershell -ExecutionPolicy Unrestricted $(ProjectDir)Minify.ps1 -ProjectDir $(ProjectDir) -TargetPath $(TargetPath)
 

# Uglify CSS - https://www.npmjs.com/package/uglifycss
Set-Location wwwroot\css
uglifycss tp.css tp-UI.css --output ..\tp.min.css
uglifycss tp.css tp-UI.css site.css --output ..\site.min.css

# npm install uglify-es -g
# Uglify JS - https://www.npmjs.com/package/uglify-es
# NOTE: fails to minify javascript classes containing fields
Set-Location ..\js
uglifyjs tp\tp.js tp\tp-UI.js -o ..\tp.min.js -c
uglifyjs tp\tp.js tp\tp-UI.js site.js -o ..\site.min.js -c
