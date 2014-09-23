<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8"/>
    <link rel="stylesheet" href="Styles/01.rootSum.css"/>
    <title>String Modifier</title>
</head>
<body>
<article>
    <form method="post">
        <label for="input"><input type="text" name="input"/></label>
        <label for="palindrome"><input type="radio" name="radioButton" value="palindrome"/>Check Palindrome</label>
        <label for="reverse"><input type="radio" name="radioButton" value="reverse"/>Reverse String</label>
        <label for="split"><input type="radio" name="radioButton" value="split"/>Split</label>
        <label for="hash"><input type="radio" name="radioButton" value="hash"/>Hash String</label>
        <label for="shuffle"><input type="radio" name="radioButton" value="shuffle"/>Shuffle String</label>
        <input type="submit" name="sub-button" value="Submit"/>
        <hr>
    </form>

    <?php


    if (isset($_POST['sub-button']) && !empty($_POST['input'])) {
        if (isset($_POST['radioButton'])) {
            if ($_POST['radioButton'] == 'palindrome') {
                $palindrome = htmlentities($_POST['input']);

                $string = strtolower(preg_replace("/[^A-Za-z0-9]/", "", $palindrome));
                $reversedString = strrev($string);
                $splitString = str_split($reversedString);
                $result = printArrayAtLine($splitString);

                if ($string == $reversedString) {
                    echo "{$palindrome} -> is a palindrome -> {$result}";
                } else {
                    echo "{$palindrome} -> is not a palindrome";
                }

            } elseif ($_POST['radioButton'] == 'reverse') {
                $letReverse = htmlentities($_POST['input']);
                $reversedString = strrev($letReverse);
                echo $reversedString;


            } elseif ($_POST['radioButton'] == 'split') {
                $letSplit = htmlentities($_POST['input']);
                //separate strings by comma, to sub-strings
                $splitInputByComma = preg_split('/[","]+/', $letSplit);
                foreach($splitInputByComma as $strSub){
                    // remove first space from left, of sub-strings(words or sentences)
                    $strSubRepl = ltrim($strSub);

                    //split the sub-string to array
                    $strSubSplit = str_split($strSubRepl);

                    // check marker
                    $check = 0;
                    // check for numeric strings
                    foreach($strSubSplit as $char){
                        if(is_numeric($char)){
                            $check = 0;
                            break 1;
                        }elseif(!is_numeric($char)){
                            $check = 1;
                        }
                    }
                    if($check == 1){
                    echo printArrayAtLine($strSubSplit);
                    }
                }

            } elseif ($_POST['radioButton'] == 'hash') {
                $letHash = htmlentities($_POST['input']);
                $result = crypt($letHash);
                echo $result;

            } elseif ($_POST['radioButton'] == 'shuffle') {
                $letShuffle = htmlentities($_POST['input']);
                $shuffledStr = str_shuffle($letShuffle);
                echo $shuffledStr;
            }
        }
    }
    function printArrayAtLine($array){
       $res= " ";
       foreach($array as $char):
           $res = "{$res} ". $char;
       endforeach;
       return $res;
   }
    ?>

</article>
</body>
</html>