<?php
require 'vendor/autoload.php';
$client=new EasyRdf\Sparql\Client("http://localhost:8080/rdf4j-server/repositories/1");
//$client=new EasyRdf\Sparql\Client("http://dbpedia.org/sparql");
echo "retrieving the client";
$interogare="prefix : <http://buchmann.ro#> SELECT * WHERE {?x ?y ?z}";
echo "creating the query";
$rezultate=$client->query($interogare);
echo "executing the query";
print $rezultate->dump();
?>
