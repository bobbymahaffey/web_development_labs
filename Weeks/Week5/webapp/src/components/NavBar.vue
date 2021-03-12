<template>
    <div class="links" v-if="loggedIn">
        <span v-on:click='goToHome'>Home</span>
        <span v-on:click='goToInstructors'>Instructors Example</span>
        <span v-on:click='goToStudents'>Students Example</span>
    </div>
</template>

<script>
  export default {
    name: 'NavBar',
    props: {
      loggedIn: Boolean
    },
    methods: {
      goToHome: function() {
        this.$router.push({ path: 'home' })
      },
      goToInstructorss: function() {
        this.$router.push({ path: 'Instructors' })
      },
      goToStudentss: function() {
        this.$router.push({ path: 'Students' })
      }
    }
  }
</script>

<style scoped>
  span {
      font-family: monospace;
      font-weight: bold;
      font-size: 14pt;
      cursor: pointer;
      padding-right: 20px;
      background-color: white;
      text-align: center;
  }
  .links {
      background-color: lightgray;
      margin-top: 20px;
      padding: 10px;
  }
</style>