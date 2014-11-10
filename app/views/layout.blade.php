<!DOCTYPE html>
<html lang="en">
    @include("head")
  <body>
    @include("header")
    <div class="content">
      <div class="container">
        @yield("content")
      </div>
    </div>
    @include("footer")
  </body>
</html>