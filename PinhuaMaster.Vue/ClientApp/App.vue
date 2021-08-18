<template>
    <div id="home">
        <mu-appbar style="width: 100%;" color="primary">
            <mu-button icon slot="left">
                <mu-icon value="menu"></mu-icon>
            </mu-button>
            Title
            <mu-menu slot="right">
                <mu-button flat>MENU</mu-button>
                <mu-list slot="content">
                    <mu-list-item button>
                        <mu-list-item-content>
                            <mu-list-item-title>Menu Item 1</mu-list-item-title>
                        </mu-list-item-content>
                    </mu-list-item>
                    <mu-list-item button>
                        <mu-list-item-content>
                            <mu-list-item-title>Menu Item 2</mu-list-item-title>
                        </mu-list-item-content>
                    </mu-list-item>
                </mu-list>
            </mu-menu>
        </mu-appbar>
    </div>
</template>
<script>
    export default {
        name: 'App'
    }
</script>
<style>
    #app {
        font-family: 'Avenir', Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        text-align: center;
        color: #2c3e50;
        margin-top: 60px;
    }
</style>