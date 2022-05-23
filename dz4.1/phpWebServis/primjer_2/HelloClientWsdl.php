<?php 

#varijable id i funkcija nisu definirane prije slanja forme
error_reporting(E_ALL ^ E_NOTICE);

$v = $_GET['id'];
$f = $_GET['funkcija'];  
 

   $client = new SoapClient("http://localhost/rnwa-main/dz4.1/phpWebServis/primjer_2/Hello.wsdl",
      array('soap_version' => SOAP_1_2,'trace' => 1 ));

   //echo("\nDumping client object functions:\n");

    //var_dump($client->__getFunctions());

   $return = $client->__soapCall("BAMtoEUR",array($v));
   //echo("\nReturning value of __soapCall() call BAM to EUR: ".$return);
    
    
    

   //echo("\nDumping request headers:\n".$client->__getLastRequestHeaders());

   //echo("\nDumping request:\n".$client->__getLastRequest());

   //echo("\nDumping response headers:\n".$client->__getLastResponseHeaders());

   //echo("\nDumping response:\n".$client->__getLastResponse());

#-------EUR TO BAM

   $return = $client->__soapCall("EURtoBAM",array($v));
   //echo("\nReturning value of __soapCall() call EURtoBAM: ".$return);

   //echo("\nDumping request headers EURtoBAM:\n".$client->__getLastRequestHeaders());

   //echo("\nDumping request EURtoBAM:\n".$client->__getLastRequest());

   //echo("\nDumping response headers EURtoBAM:\n".$client->__getLastResponseHeaders());

   //echo("\nDumping response EURtoBAM:\n".$client->__getLastResponse())."</pre>";

#------EUR TO HRK
  
   $return = $client->__soapCall("EURtoHRK",array($v));
   //echo("\nReturning value of __soapCall() call: ".$return);

   //echo("\nDumping request headers EURtoHRK:\n".$client->__getLastRequestHeaders());

   //echo("\nDumping request EURtoHRK:\n".$client->__getLastRequest());

   //echo("\nDumping response headers EURtoHRK:\n".$client->__getLastResponseHeaders());

   //echo("\nDumping response EURtoHRK:\n".$client->__getLastResponse())."</pre>";

#-----HRK TO EUR

   $return = $client->__soapCall("HRKtoEUR",array($v));
   //echo("\nReturning value of __soapCall() call: ".$return);

   //echo("\nDumping request headers HRKtoEUR:\n".$client->__getLastRequestHeaders());

   //echo("\nDumping request HRKtoEUR:\n".$client->__getLastRequest());

   //echo("\nDumping response headers HRKtoEUR:\n".$client->__getLastResponseHeaders());

   //echo("\nDumping response HRKtoEUR:\n".$client->__getLastResponse())."</pre>";
   

if ($f == "BAMtoEUR") {     
   $return = $client->__soapCall("BAMtoEUR",array($v));
   echo("\nPretvorba ". $v . " BAM to EUR je: ".$return);

} elseif ($f == "EURtoBAM") {
  $return = $client->__soapCall("EURtoBAM",array($v));
   echo("\nPretvorba ". $v . " EUR to BAM je: ".$return);

} elseif ($f == "EURtoHRK") {
  $return = $client->__soapCall("EURtoHRK",array($v));
   echo("\nPretvorba ". $v . " EUR to HRK je: ".$return);

} elseif ($f == "HRKtoEUR") {
  $return = $client->__soapCall("HRKtoEUR",array($v));
   echo("\nPretvorba ". $v . " HRK to EUR je: ".$return);

} else {
    echo "Unesite valutu i odaberite funkciju za pretvorbe!";
}




?>




