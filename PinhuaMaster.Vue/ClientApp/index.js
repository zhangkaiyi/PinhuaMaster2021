import Vue from 'vue'
import VueRouter from 'vue-router'
import App from './App.vue'
import MuseUI from 'muse-ui';
import 'muse-ui/dist/muse-ui.css';

Vue.config.productionTip = false

Vue.use(VueRouter)

const routes = [
    {
        path: '/',
        component: App,
    },
    {
        path: '/index.html/',
        component: App,
    }
]

const router = new VueRouter({
    routes,
    mode: 'history'
})

new Vue({
    el: '#app',
    template: "<div><router-view></router-view></div>",
    mounted: function () {
        fetch('api/SampleData/WeatherForecasts')
            .then(response => response.json())
            .then(data => {
                // data就是我们请求的repos
                console.log(data)
            });
    },
    router
})