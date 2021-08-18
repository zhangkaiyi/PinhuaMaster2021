<!-- item template -->
<script type="text/x-template" id="navmenu-template">
	<div class="dd" id="nmm">
		<ol class="dd-list">
			<nav-item v-for="(menu, index) in root" :key="index" :model="menu" ></nav-item>
		</ol>
		<form method="post">
			<textarea style="height:800px;width:800px;" id="ta">{{root}}</textarea>
		</form>
	</div>
</script>
<script type="text/x-template" id="navmenu-item-template">
	<li class="dd-item dd3-item" :data-url="model.url" :data-icon="model.icon" :data-name="model.name" :data-id="model.id">
		<div class="dd-handle dd3-handle">Drag</div><div class="dd3-content">
			<i :class="model.icon"></i> {{model.name}}
			<span class='pull-right'>
				<a style="cursor: pointer" @@click="del($event)">
					<i class="fa fa-times text-danger"></i>
				</a>
			</span>
		</div>
		<ol class="dd-list" v-if="isFolder">
			<nav-item v-for="(menu, index) in model.children" :key="index" :model="menu"></nav-item>
		</ol>
	</li>
</script>

        <script>
            Vue.component('navmenu-management', {
                template: '#navmenu-template',
            props: {
                model: Array
            },
            data: function () {
                return {root: this.model }
            },
            mounted: function () {
                var self = this
                var el = $('#nmm')
                el.nestable()
            },
            methods: {
                test: function (e) {
                console.log(e)

            }
            }
            ,
            components: {
                'nav-item': {
                template: '#navmenu-item-template',
                    name: 'nav-item',
                    props: {
                model: Object,
                    },
                    computed: {
                isFolder: function () {
                            return this.model.children &&
                                this.model.children.length
                        },
                    },
                    methods: {
                selectNode: function () {
                this.$emit('selectNode', this.model)
            },
                        addChild: function () {
                this.model.children.push({
                    name: '新菜单',
                    icon: 'fa fa-circle-o',
                    url: '/Index'

                })
            },
                        del: function (event) {
                            var el = event.target
                            $(el).closest('li').remove()
                        }
                    },
                }
            }
        })
        var jsonObject = []
        $.ajax({
                url: "/MenuSystem?Handler=NavMenu",
            async: false,
            success: function (data) {
                jsonObject = JSON.parse(data)
            }
            })
        var app = new Vue({
                el: '#app',
            data: {
                navmenu: jsonObject
            },
            methods: {
                addChild: function () {
                this.navmenu.push({
                    name: '新菜单',
                    icon: 'fa fa-circle-o',
                    url: '/Index'

                })
            },
                test: function () {
                alert(111)

            }

            },
            mounted: function () {

            }
            })

    </script>
