@extends("layout")
     @section("content")
        <link href="/css/input.css" rel='stylesheet' type='text/css' />
       {{ Form::open() }}
         {{ $errors->first("password") }}<br />

         {{ Form::label("username", "Username") }}
         {{ Form::text("username", Input::old("username")) }}<br />

         {{ Form::label("email", "Email") }}
         {{ Form::text("email") }}<br />

         {{ Form::label("password", "Password") }}
         {{ Form::password("password") }}<br />

         {{ Form::label("password1", "Repeat password") }}
         {{ Form::password("password1") }}<br />


         {{ Form::submit("Register") }}
       {{ Form::close() }}
     @stop