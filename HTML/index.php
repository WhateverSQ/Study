<?php
$Name = 'Никита';
$arr = [
    'key0' => 'RandomFact0',
    'key1' => 'RandomFact1'
]
?>



<!DOCTYPE html>
<html lang="en">
<head>
    <script language="JavaScript" src="./assets/js/script.js"> </script>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="shortcut icon" href="./assets/img/favicon/favicon.png">
    <link rel="stylesheet" type="text/css" href="./assets/css/style.css">
    <title>My memes</title>
</head>
<body>
<header>
   <h1>Мои мемы</h1>
   <div class="logo">
    <img src="./assets/img/logo.png" alt="logo">
   </div>
   <nav>
    <li><a href="./">Главная</a></li>
    <li><a href="#Beloved_meme">Любимый мем</a></li>
    <li><a href="#contact">Контакты</a></li>
    <li><a href="#very_old">Старые мемы</a></li>
    <li><a href="#fact">Факт</a></li>
   </nav> 
</header>
<div class="main">
    <div class="container">
        <p class="text">
            <p> На данной страничке я собрал некоторую часть из моих сохраненных мемов. Хоть и не все они так же радуют меня до сих пор, я их все равно люблю. Надеюсь и вам какой-нибудь понравится!</p>
            <p>
                <img src="https://sun9-east.userapi.com/sun9-31/s/v1/ig2/aJTt2htC5KaLyxFpFSVAvCOw4WmZAR99Wo700kR7Xlx5_pQZmbiDfhd3cPRCzGQkf1dcEObPs-Xv7XsPOvFN5-Aj.jpg?size=320x292&quality=96&type=album" alt="Мем">
            </p>
            <section>
                <h2 id="fact">Факт</h2>
            <p>
                <img src="https://sun9-east.userapi.com/sun9-43/s/v1/ig2/0hBGXP_q3cGPKrCNY2Pgu2e9sSTcD9lZb6_w7-9UTNNIozzKmhZzltAtY_yHIhvqOwwuLDEZ314qzZhXZN8Pg2Nz.jpg?size=640x468&quality=96&type=album" alt="Мем-кот">
            </p>
            <ol>
                <li>Начал сохранять мемы еще 7 лет назад</li>
                <li>Сохраняю их очень редко</li>
                <li><?php echo $arr['key0']; ?></li>
            </ol>        
            <h2 id="Beloved_meme">Любимый мем</h2>
            <img src="https://sun2.userapi.com/sun2-22/s/v1/ig2/fUFmDx4LZ0DZynqsgBFwClAUhSx6JBjpgUSL4u0z5pzUNCz9qLPzQmqLOLBlLN7r8ABcm3RzhamsC8GNlWpS4DhO.jpg?size=500x482&quality=95&type=album" alt="Любимый мем">
        </p>
        <p>
            <h2 id="very_old">Довольно старые мемы</h2>
            <img src="https://sun9-west.userapi.com/sun9-38/s/v1/if1/8QclQ7Tdp_0JK6MCbnOkkyfpepQZblDWBh--_71NoCxGDYhUnZ-UchjSBDVp3WBQ1SWVFS8Y.jpg?size=696x522&quality=96&type=album" alt="Сынок">
        </p>
        <p>
           <img src="https://sun9-east.userapi.com/sun9-23/s/v1/if1/iaM9ZCBWJaqBAK2PD8T4VK1ENlT6bOcSeEPRw6mi-_3TlpJXuCGfz4vQ_Gu4-o8qOBGKV_rO.jpg?size=461x444&quality=96&type=album" alt="Нет, не похоже">
        </p> 
        <p>
            <img src="https://sun9-north.userapi.com/sun9-79/s/v1/if1/dhYFjQzL1dPXCIvNhheH54rGLh4IJ4SAghY80-waP21H_thVy08Bc9kegyHRjm1O6fv7Bw.jpg?size=600x479&quality=96&type=album" alt="Фримен и распрыжка">
        </p>
        <p>
            <img src="https://sun9-east.userapi.com/sun9-57/s/v1/if1/mVENjP6A-3JInnusCYOcNWt1ldX7wqEpqJtU80ucW-UZ_gKrzkM4fhq3XcpYcn5i1fajf-U9.jpg?size=559x627&quality=96&type=album" alt="Spiders!">
        </p>
        <p>
            <img src="https://sun9-west.userapi.com/sun9-47/s/v1/if1/mjfAvKfG5jjMUfKE9rbAcLpxqE1-Wnhju1W0olCyVxSn79QSJJDYgHcl6NWn_zWf4YduKkQX.jpg?size=648x432&quality=96&type=album" alt="Курица">
        </p>
    </div>
</div>
<footer>
    <div class="footer_text">
        <p>&#169; Все права защищены</p>
        <p>Все материалы на сайте взяты из свободных источников</p>
        <p id="contact"><a class="text_link" href="https://vk.com/anat0lyi" target="_blank">Моя страничка ВК</a></p>
    <p><a href="#top">Наверх</a></p>
    </div>
</footer>    
</body>
</html>