<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# File Upload in ASP.NET
<div class="signature">
    <p class="signature-course">Telerik Software Academy</p>
    <p class="signature-initiative">http://academy.telerik.com </p>
    <a href = "ASP.NET Web Forms" class="signature-link">ASP.NET Web Forms</a>
</div>

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Table of Contents
- File Upload Concepts
- Multipart HTTP Requests
- File Upload in ASP.NET Web Forms
  - To server file
  - To memory stream
- Using Kendo UI Upload
- Using Telerik ASP.NET AJAX

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# File Upload Concepts
##  How files are sent through the web

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# File Upload Concepts

- Done through forms
- Content type should be “multipart/form-data” 
- Selected via input type “file” tag
- Data is sent as POST method through http
- Files are received and used at the server

```aspx
<form id="FileUploadForm" runat="server">
   <asp:FileUpload ID="FileControl" runat="server">
   <asp:Button runat="server" ID="UploadButton" 
        Text="Upload" OnClick="Upload">
</form>
```

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Multipart HTTP Request
##  Different kind of POST method

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Multipart HTTP Request

- Form is sent as multiple parts
- Enable multipart – type “multipart/form=data”
- Request is divided in parts

```
Content-Type: multipart/form-data; boundary=-------------
--------------7d81b516112482
Content-Length: 324
-----------------------------7d81b516112482
Content-Disposition: form-data; name="file"; 
    filename=“Exam solution.doc"
Content-Type: text/plain
SomeText
-----------------------------7d81b516112482
Content-Disposition: form-data; name="submit"
```


<!-- attr: { class:'slide-section demo', showInPresentation:true, style:'' } -->
<!-- # Multipart HTTP Request -->
##  [Demo]()

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET Web Forms File Upload
## Done within minutes

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET File Upload Classes

- Request.Files
  - Gets the collection of sent files (dictionary)
  - Uses MIME format
- HttpPostedFile
  - Provides access to individual files
  - string FileName property
  - int ContentLength in bytes
  - InputStream – stream of the file
  - SaveAs(string fileName) – saves the file

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET File Upload Classes

- FileUpload
  - bool HasFile – checks if file is uploaded
  - byte[] FileBytes – file content in binary
  - Stream FileContent – file as stream
  - string FileName – name of the file
  - HttpPostedFile PostedFile – posted file
  - `IList<HttpPostedFile>` PostedFiles – collection of all uploaded files


<!-- attr: { showInPresentation:true, style:'' } -->
# ASP.NET File Upload

- Using `&#60;asp: FileUpload /&#62;`

```aspx
&#60;asp:FileUpload ID="FileControl" runat="server" /&#62;
```
- In the code behind

```cs
if (FileControl.HasFile)
   {
     string filename = Path.GetFileName 
        (FileControl.FileName);
     FileControl.SaveAs(Server.MapPath
        ("~/Uploaded_Files/") + filename);
   }
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, style:'' } -->
<!-- # Simple File Upload -->
##  [Demo]()

<!-- attr: { showInPresentation:true, style:'font-size: 44px' } -->
# Restricted File Upload

- You can check for certain file types

```cs
if (FileControl.PostedFile.ContentType == "image/jpeg")
{
    // Use file
}
else
{
    // do not upload
}
```
- You can check for file size

```cs
if (FileControl.PostedFile.ContentLength < 102400)
{
    // Use file
}
…
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, style:'' } -->
<!-- # Restricted File Upload -->
##  [Demo]()

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Uploading To Stream
- Saving file to stream

```cs
byte[] fileData = null;
Stream fileStream = null;
int length = 0;
if (FileUploadControl.HasFile)
{
   length = FileControl.PostedFile.ContentLength;
   fileData = new byte[length + 1];
   fileStream = FileControl.PostedFile.InputStream;
   fileStream.Read(fileData, 0, length);
}
MemoryStream stream = new MemoryStream(fileData);
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, style:'' } -->
<!-- # Uploading To Stream -->
##  [Demo]()

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Kendo UI Upload Widget
##  Asynchronous and large files support 

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Kendo UI Upload
- Kendo Upload widget
  - Easily done
  - Have upload and delete
  - Styled and ready to use
  - Supports asynchronous file upload
  - Supports multiple file upload at once
  - Supports sending large files in parts

<!-- attr: { showInPresentation:true, style:'' } -->
# Kendo UI Upload
- Steps for asynchronous large multi-upload
  - Create landing page for the widget
  - Add input type “file” (no form required)
  - Add JavaScript for the widget
  - Add upload handler
  - Add remove handler (if you need it)
  - In `web.config` set request max length

```xml
&#60;httpRuntime targetFramework="4.5" 
    executionTimeout="110" maxRequestLength="25000" /&#62;
```

<!-- attr: { showInPresentation:true, style:'font-size: 42px' } -->
# Kendo UI Upload
- Landing page

```html
&#60;input name="uploaded" id="uploaded" type="file" runat="server" /&#62;
&#60;script&#62;
     $(document).ready(function () {
         $("#uploaded").kendoUpload({
             async: {
                 saveUrl: "Upload",
                 removeUrl: "Remove",
                 autoUpload: true,
                }
            });
        });
&#60;/ script&#62;
```

<!-- attr: { showInPresentation:true, style:'' } -->
# Kendo UI Upload
- Upload page
- Get name of the input from Request.Files
- Return empty response if successful

```cs
Response.Expires = -1;
HttpPostedFile file = Request.Files["uploaded"];

string savepath = Server.MapPath("~/Uploaded_Files/");
string filename = file.FileName;
file.SaveAs(savepath + filename);

Response.ContentType = "application/json";
Response.Write("{}");
```

<!-- attr: { showInPresentation:true, style:'' } -->
# Kendo UI Upload
- Remove page
- Get file from Request.Form["fileNames"]
- If file exists – delete it

```cs
var file = Request.Form["fileNames"];

if (file != null)
{
    var fileName = Path.GetFileName(file);
    var physicalPath = Path.Combine 
        (Server.MapPath("~/Uploaded_Files"), fileName);
    if (File.Exists(physicalPath))   
        File.Delete(physicalPath);
}
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, style:'' } -->
<!-- # Kendo UI Upload Widget -->
##  [Demo]()

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Telerik ASP.NET AJAX
## Designed for Web Forms

<!-- attr: { showInPresentation:true, style:'' } -->
# Kendo UI Upload
- Steps for asynchronous file upload
  - Install ASP.NET AJAX Controls
  - Add RadAsyncUpload control to a page
  - Add RadScriptManager (in web.config too)
  - Set MultipleFileSelection
  - Set TargetFolder
  - Add RadButton or normal ASP submit button

<!-- attr: { class:'slide-section demo', showInPresentation:true, style:'' } -->
<!-- # Telerik ASP.NET AJAX -->
##  [Demo]()

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# ASP.NET File Upload

<img class="slide-image" src="imgs/questions.png" style="width:80%; top:15%; left:10%" />
<div style="position: absolute; bottom: 1em; right: 0; font-size: 26px;">http://academy.telerik.com</div>