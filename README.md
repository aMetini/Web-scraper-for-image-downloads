# Web-scraper for image downloads

Web scraping is a method for looking through the web (or limited parts of it) for data and collecting information. This is mostly done by scanning
(HTML) code that websites are built on, and in many cases in combination with a so-called "Crawler" that follows links that one may find in order to move further to
additional pages.

I built simple web scraper (without crawler) where one can enter a web address and automatically download images that are on the page. The app is built using Winforms (.NET Framework), and it uses asynchronous calls.

The program consists of a text box where you enter a webaddress (URL) and oneButton "extract". When ones clicks the button (or ENTER) the program downloads HTML code from the URL entered, searching the URL for links to pictures, and displays all links it finds in a multiline text box. The program also indicates how many image links
were found on the page.

One can click on a button "Save Images" that opens a folder browser dialog where one can choose a folder where you want to save all the pictures.
When selecting a folder (and clicked "OK"), the program asynchronously downloads all pictures via the links and save them to files in the order that they were downloaded.  This is done by creating a new task for each download and then using Task.Whenany () to handle every task when it gets done. 
When a task is ready, the program takes the binary data that it downloaded from the link and writes it directly to a binary file.
You can rename the files eg image1, image2 etc. But keep in mind that the file extension must match the data for the file to go to open. If the link points to (for
example) a .png file, the file must be called eg image5.png

HTML
Websites are usually built in HTML (Hypertext Markup Language) that is a (Markup) language to describe the websites structure. Html is thus not a true programming
language in the way C #, Java, or other languages are.  It is just a (ASCII) text with so-called tags (eg <HTML>) describing for the browser how the page
shall be drawn up (rendered). Different tags describe different things, and the only thing we need to know for this program is that there is a tag <img> in HTML that
contains links to images.
Therefore, the application must search for "<img" in the HTML code to find (the beginning of) an image tag. A tag in HTML always starts with <and ends with>, so to find the end of the tag and we are looking forward until we find >.
      Example of a typical <IMG> Tag:  <img class = "myclass" src = "/ example-image.png">
HTML tags can contain zero, one, or more attributes. The tag above contains the attributes 'Class' and 'SRC'. The application is focuesed on the value of
the 'src' attribute. The value is essentially the image link we are looking for. Sometimes the attribute that holds the link is called 'data src' instead.
  
Regular Expressions.
With regex.matches () you can get all parts of the HTML code that matches the expression that you write.  In principal, one needs a look-behind that looks for tags that begins with <IMG, and SRC = "comes right before what you want to match>. One must also keep in mind that the 'src' attribute is not necessarily the last attribute of an <img> tag. Different websites can be built in many different ways. Image links may be enclosed in other types of tags, or in other ways. This is why it is very hard to write a general scraper that finds all pictures/images, and works on all types of pages. The RegEx expression that I use in this application follows a more narrowly defined search criteria.
