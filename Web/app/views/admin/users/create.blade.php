@extends('admin._layouts.admin')

@section('content')

<h1>Create User</h1>
{{ Form::open(array('route' => 'admin.users.store')) }}
    @include('admin.users._partials.form')
{{ Form::close() }}
@stop