<!DOCTYPE html>
<html>
    <head>
         <meta charset="UTF-8">
         <title>SuitsApp | Dashboard</title>
         <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">

    </head>

    <body>
        <header>
        </header>
        <main class="container">
            @yield('content')
        </main>

        <footer>
            <div class="container">
                &copy; {{ date('Y') }} SuitsApp
            </div>
        </footer>
    </body>
</html>