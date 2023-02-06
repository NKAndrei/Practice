<?php

$opts = array(
  'http'=>array(
    'method'=>"GET",
    'header'=>"Accept: application/json, text/javascript, */*; q=0.01\r\n",
                "Accept-Encoding: gzip, deflate, br\r\n"
  )
);

$context = stream_context_create($opts);
$query = "prefix : <http://buchmann.ro#> SELECT * WHERE {?x ?y ?z}";
$encoded_query = rawurlencode($query);
/* Sends an http request to www.example.com
   with additional headers shown above */
   //$fp = fopen('http://www.example.com'.$encoded_query, 'r', false, $context);
$fp = file_get_contents('http://localhost:8080/rdf4j-server/repositories/1?query='.$encoded_query,false, $context); // file_get_contents returns a valid json
//$fp = fopen('http://localhost:8080/rdf4j-server/repositories/1?query='.$encoded_query,'r',false, $context); // fopen is not good, not a valid json
echo $fp;
//fpassthru($fp);
//fclose($fp);

?>