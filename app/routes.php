<?php


Route::get('/', "HomeController@showWelcome");

Route::any("/registration", [
    "as"   => "/registration",
    "uses" => "UsersController@registration"
]);


Route::any("/login", [
    "as"   => "user/login",
    "uses" => "UsersController@login"
]);

Route::group(["before" => "auth"], function() {

    Route::any("/profile", [
        "as"   => "user/profile",
        "uses" => "UsersController@profile"
    ]);

});

Route::any("/request", [
    "as"   => "user/request",
    "uses" => "UsersController@request"
]);

Route::any("/reset/{token}", [
    "as"   => "user/reset",
    "uses" => "UsersController@reset"
]);

Route::any("/logout", [
    "as"   => "user/logout",
    "uses" => "UsersController@logout"
]);