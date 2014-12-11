<ul>

    <li>
        {{ Form::label('email', 'Email') }}
        {{ Form::text('email') }}
        {{ $errors->first('email', '<p class="error">:message</p>') }}
    </li>
    <li>
           {{ Form::label('permission', 'Permission') }}
           {{ Form::select('permission', User::lists('permission')) }}
           {{ $errors->first('permission', '<p class="error">:message</p>') }}
    </li>
    <li>
            {{ Form::label('created_at', 'Created') }}
            {{ Form::text('created_at') }}
            {{ $errors->first('created_at', '<p class="error">:message</p>') }}
    </li>
    <li>
            {{ Form::label('updated_at', 'Updated') }}
            {{ Form::text('updated_at') }}
            {{ $errors->first('updated_at', '<p class="error">:message</p>') }}
        </li>



    <li>
        {{ Form::submit('Save') }}
    </li>
</ul>