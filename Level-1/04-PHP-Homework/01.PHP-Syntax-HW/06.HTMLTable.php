<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <title>Info Tab</title>
        <style>
            section{
                margin: 0;
                padding: 0;
            }
            article{
                margin: 1rem;
            }
            table{
                font-family: Verdana, Arial;
                font-size: 0.8rem;
                text-align: left;
                box-sizing: border-box;
                border-collapse: collapse;
                border: 2px solid green;
            }
            tr th{
                padding: 0.4rem 0.9rem;
                background-color: lightgoldenrodyellow;
                border: 2px solid green;
                text-transform: capitalize;
            }
            tr td{
                padding: 0.4rem 0.9rem;
                text-align: right;
                border: 2px solid green;
            }
        </style>
    </head>
    <body>
        <section>
            <?php
                $addName = 'Gosho';
                $addPhone = '0882-321-423';
                $addAge = '24';
                $addAddress = 'Hadji Dimitar';

                $arrayInfo['name'] = $addName;
                $arrayInfo['phone number'] = $addPhone;
                $arrayInfo['age'] = $addAge;
                $arrayInfo['address'] = $addAddress;
            ?>

            <article>
                <?php echo "<table>\n" ?>
                    <?php foreach($arrayInfo as $key => $value){ ?>
                    <?php echo "<tr>\n"; ?>
                    <?php echo "<th>$key</th>\n"; ?>
                    <?php echo "<td>$value</td>\n";?>
                    <?php echo "</tr>\n"; ?>
                    <?php } ?>
                <?php echo "</table>\n" ?>
            </article>
        </section>
    </body>
</html>

