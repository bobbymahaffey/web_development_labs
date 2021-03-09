<template>
  <div>
      <div class="form-entry">
                    First Name: <input id='first-name' type="text" name="firstName"/>
                    <span id='first-name-error' class='error-msg' style='visibility:hidden'>Please enter first name.</span>
                </div>
    
                <div class="form-entry">
                    Last Name: <input id='last-name' type="text" name="lastName"/>
                    <span id='last-name-error' class='error-msg' style='visibility:hidden'>Please enter last name.</span>
                </div>
    
                <div class="form-entry">
                    <input type="button" value="Register" onclick="validate()"/>
                </div>
  </div>
</template>

<script>
export default {
  name: 'Students',
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style>

</style>
