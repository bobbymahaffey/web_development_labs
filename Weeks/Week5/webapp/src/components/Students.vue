<template>
    <div>
        <h2 class='section-heading'>Students</h2>
        <table>
            <thead>
                <tr>
                    <th>Last Name</th>
                    <th>First Name</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students" v-bind:key="student.lastName">
                    <td>{{ student.lastName }}</td>
                    <td>{{ student.firstName }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    export default {
        name: 'Tables',
        mounted() {
            this.students = getStudents();
        },
        data () {
            return {
                students: []
            }
        }
    }
    function getStudents() {
        return JSON.parse(students);
    }
    var students = '[{"firstName": "Bobby", "lastName": "Mahaffey"}, {"firstName": "Kristina", "lastName": "Mahaffey"}]';
</script>

<style scoped>
    table, th, td {
        padding: 10px;
        border: 5px solid black; 
        border-collapse: collapse;
    }
</style>
