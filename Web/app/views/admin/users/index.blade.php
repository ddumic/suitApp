@extends('admin._layouts.admin')

     @section('content')

     <h1>Users</h1>
     {{ link_to_route('admin.users.create', 'Create new User') }}

     @if(count($users))
         <ul>
         @foreach($users as $user)
             <li>
                 {{ link_to_route('admin.users.edit', $user->email, array($user->id)) }}
                 {{ Form::open(array('route' => array('admin.users.destroy', $user->id), 'method' => 'delete', 'class' => 'destroy')) }}
                 {{ Form::submit('Delete') }}
                 {{ Form::close() }}
             </li>
         @endforeach
         </ul>
     @endif

     @stop