<?php

class UserSeeder
    extends DatabaseSeeder
{
    public function run()
    {
        $users = [
            [
                "username" => "roko",
                "password" => Hash::make("roko"),
                "email"    => "roko.labrovic@gmail.com"
            ]
        ];

        foreach ($users as $user) {
            User::create($user);
        }
    }
}