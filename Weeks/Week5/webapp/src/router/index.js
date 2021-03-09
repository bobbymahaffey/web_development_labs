import Vue from 'vue';
import Router from 'vue-router';
import Home from '@/components/Home';
import Students from '@/components/Students';
import Instructors from '@/components/Instructors';

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      component: Students
    },
    {
      path: '/home',
      component: Home
    },
    {
      path: '/forms',
      component: Students
    },
    {
      path: '/tables',
      component: Instructors
    }
  ]
})