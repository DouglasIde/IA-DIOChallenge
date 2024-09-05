<h1 align="center">📸 Converting Image to Text ✍🏻</h1>
<img src="https://github.com/DouglasIde/IA-ImageToText/blob/main/inputs/README_files/douglas-tesseract-project-dio-challenge.jpg" alt="Imagem de capa do projeto do Douglas da DIO"
  target="_blank">

<div align="center">
  <em>
    IDE: <a href="https://visualstudio.microsoft.com/pt-br/">Visual Code</a><br><br>
  </em>
  
  <a href="https://www.linkedin.com/in/douglas-yugo/" target="_blank">
    <img src="https://img.shields.io/static/v1?label=Author&message=DouglasYugo&color=purple&style=for-the-badge&logo=LinkedIn" alt="Author: Douglas Yugo">
  </a>
  <img src="https://img.shields.io/static/v1?label=Language&message=C%23&color=purple&style=for-the-badge&logo=sharp" alt="Language: C#">
  <img src="https://img.shields.io/static/v1?label=Framework&message=.NET&color=purple&style=for-the-badge&logo=dotnet" alt="Framework: .NET">
</div>


<h1>📌Description</h1>
<p>The project was developed as part of the conclusion of the DIO Bootcamp, with a focus on exploring Generative Artificial Intelligence resources, such as OpenAI and GitHub Copilot.

The main aim of the project was to recognize text in images stored in the "inputs" folder. To do this, I created an API using C# and .NET, which captures the texts contained in the 
images and displays the results on the console. To read and extract the texts from the images, I used Tesseract, an open source OCR tool.</p><br>

<h1>🤖Technologies</h1>
<li><strong><a href="https://copilot.microsoft.com/" target="_blank">Copilot</strong> : Creating images for the presentation.</li>
<li><strong><a href="https://dotnet.microsoft.com/pt-br/languages/csharp" target="_blank">C# and .NET</strong> : I used these technologies to create the API with Tesseract.</li> 
<li><strong><a href="https://github.com/tesseract-ocr/tesseract" target="_blank">Tesseract</strong> : To recognize text in images.</li><br>

<h1>⚠Warning</h1>
<p>To use Tesseract, you'll need to download it to your machine. In <strong>Technologies</strong> you'll
find it with a link to all the documentation, including installation.

You also need to install the <strong>trainedddata</strong>, which is responsible for
teaching Tesseract about the languages it can find in the images. Each "traineddata" file has its own 
language.

The images you run Tesseract on should preferably be in black and white. Try to follow the example images
in the <strong>Inputs folder</strong>

It may be that the API doesn't perfectly recognize what's in the image because of the fonts that are used in the image.
</p><br>

<h1>📁Folders</h1>
<ul>
  <li><strong>Inputs</strong> : Folder where the images are stored.</li>
  <li><strong>Outputs</strong> : Folder where the Tesseract results are stored.</li>
  <li><strong>ImageRecognition</strong> : Folder containing the API that recognizes text in images.</li>
</ul><br>

<h1>🧐Creation Process</h1>
<ol>
  <li>First I started looking for images where I chose the theme of heroes like Marvel and DC.</li>
  <li>I explored Azure and created the API in C# and .NET.</li>
  <li>I challenged myself and wanted to find something in open code and I found Tesseract where I began to study the documentation on how to use it.</li>
  <li>I'd to edit the images and make them black and white with high contrast so that Tesseract could read them.</li>
  <li>Finally, I finalized the API by improving some features for Tesseract to read and put in two languages to avoid any kind of error during reading.</li>
</ol><br>

<h1>🚀Results</h1>
<p>The results met expectations, correctly returning the text contained in the images. Below is a sample of the results obtained, along with a link to a short presentation explaining the project and the development of the DIO challenge.</p>

<div align="center">
  <img src="https://github.com/DouglasIde/IA-ImageToText/blob/main/inputs/README_files/gifs/demo-ia-tesseract.gif" alt="Gif with a system presentation"><br>
</div>

<h1>💭Reflections</h1>
<p>The DIO challenge provided significant learning in the use of Copilot, especially in the elaboration of prompts to obtain valuable tips on the use of Tesseract, allowing me to solve problems and difficulties to achieve the expected results. In addition, I learned how to use some Azure tools, including integration with API_KEYS, which contributed to improving my C# and .NET skills. I was also introduced to Tesseract, an open source tool that I found extremely useful and impressive.</p>




