# add a Pre-Build task as
# powershell -ExecutionPolicy Unrestricted $(ProjectDir)Less.ps1 -ProjectDir $(ProjectDir) -TargetPath $(TargetPath)

# Less
Set-Location wwwroot\less
lessc font-awesome.less ..\css\font-awesome.css
lessc glyphicons.less ..\css\glyphicons.css
lessc tp.less ..\css\tp.css
lessc tp-UI.less ..\css\tp-UI.css
lessc site.less ..\css\site.css