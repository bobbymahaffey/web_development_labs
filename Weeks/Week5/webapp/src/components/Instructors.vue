<template>
    <div>
        <h2 class='section-heading'>Instructors</h2>
        <table>
            <thead>
                <tr>
                    <th>Last Name</th>
                    <th>First Name</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="instructors in Instructors" v-bind:key="instructors.lastName">
                    <td>{{ instructors.lastName }}</td>
                    <td>{{ instructors.firstName }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    export default {
        name: 'Tables',
        mounted() {
            this.Instructors = getInstructors();
        },
        data () {
            return {
                Instructors: []
            }
        }
    }
    function getInstructors() {
        return JSON.parse(Instructors);
    }
    var Instructors = '[{"firstName": "Kameron", "lastName": "Mahaffey"}, {"firstName": "Taye", "lastName": "Mahaffey"}]';
</script>

<style scoped>
    table, th, td {
        padding: 10px;
        border: 5px solid black; 
        border-collapse: collapse;
    }
</style>