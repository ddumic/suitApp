@extends('admin._layouts.admin')

@section('content')

<h1>Edit User</h1>
    {{ Form::model($user, array('route' => array('admin.users.update', $user->id), 'method' => 'put')) }}
        @include('admin.users._partials.form')
    {{ Form::close() }}
@stop