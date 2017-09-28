 #pragma strict
 public var Level = "Avance1";
 
 function LoadLevel()
 {
 	Application.LoadLevel(Level);
 }

 function Home()
 {
 	Application.LoadLevel("Inicio");
 }

 function LosCien()
 {
 	Application.LoadLevel("100");
 }

  function Info()
 {
 	Application.LoadLevel("Info");
 }

  function Instrucciones()
 {
 	Application.LoadLevel("Instrucciones");
 }

  function Facebook()
 {
 	Application.OpenURL ("https://www.facebook.com/pasionxlecturamty");
 }

 function Twitter()
 {
 	Application.OpenURL ("https://twitter.com/PasionxLectura");
 }

 function URL()
 {
 	Application.OpenURL ("http://www.pasionporlalectura.itesm.mx/");
 }

 function Salir()
 {
 	Application.Quit();
 }
