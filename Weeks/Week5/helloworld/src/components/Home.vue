<template>
  <div id="home">
    <img src="../assets/saltwater.jpg" alt="There should be a picture of my Aquarium" style="width:1024px;height:512px">

        <h2 id="Hello"></h2>
        
        <h2>Date: <span id='current-date'></span></h2>

        <h2 class="section-heading">About ME!</h2>

        <div id="first-section">
            <p>
                I am a 43 year old father of 5 boys. And that pretty much it. 
            </p>
            <p>
                Just kidding. My passion is designing and aquariums. 
            </p>
        </div>

        <h2 class="section-heading">OIT</h2>

        <div id="second-section">
            <p>
                This term I am taking 4 courses plus a TA.
            </p>
            <p>
                And I only have two terms until a graduate. 
            </p>
        </div>

        <h3 class="section-heading">Passion</h3>

        <div id="third-section">
            <p>
                The are two kinds of aquarium water.
            </p>
            <p>
                Salt and Fresh
            </p>

        </div>

        <div class="links">
            <span>

            </span>
        </div>
        <!--removeIf(production)-->
        <script src='scripts/index.js'></script>
        <!--endRemoveIf(production)-->
  </div>
</template>

<script>
export default {
  name: 'Home',
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
            div {
                background-color: lightyellow;
            }
</style>
