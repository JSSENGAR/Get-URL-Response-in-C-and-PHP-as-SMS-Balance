<?php
						$url = "http://enterprise.smsgupshup.com/apps/apis/accInfo?userid=XXXXX&password=XXXX&method=balanceCheck";
						$ui = curl_init();
						curl_setopt($ui, CURLOPT_URL, $url);
						curl_setopt($ui, CURLOPT_SSL_VERIFYPEER, false);
						curl_setopt($ui, CURLOPT_RETURNTRANSFER, true);
						curl_setopt($ui, CURLOPT_FOLLOWLOCATION, true );
						curl_setopt($ui, CURLOPT_ENCODING, "gzip,deflate");     
						$resp = curl_exec($ui);
						curl_close($ui);
						echo $resp;
?>