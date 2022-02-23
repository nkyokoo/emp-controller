<template>
  <div id="app">
    <v-app>
      <v-system-bar
        window
        app
        dark
        class="moveWindow"
      >
        <span class="WindowBarTitle">EMP Controller</span>
        <v-spacer></v-spacer>
        <v-btn class="WindowBarBtn" @click="minimiseApp" icon>
          <v-icon>mdi-minus</v-icon>
        </v-btn>
        <v-btn class="WindowBarBtn" @click="maximiseApp" icon>
          <v-icon>mdi-checkbox-blank-outline</v-icon>
        </v-btn>
        <v-btn class="WindowBarBtn" @click="closeApp" icon>
          <v-icon>mdi-close</v-icon>
        </v-btn>
      </v-system-bar>
     <v-navigation-drawer
      app
      permanent
      clipped
      mini-variant
     >
       <v-list
         dense
         class="sidebar"
       >
         <v-list-item
           v-for="{icon, path, title} in items"
           :key="title"
           link
           :to="path"
         >
           <v-list-item-icon>
             <v-icon>{{icon}}</v-icon>
           </v-list-item-icon>
           <v-list-item-content>
             <v-list-item-title>{{ title }}</v-list-item-title>
           </v-list-item-content>
         </v-list-item>
         <v-list-item
           link
           to="settings/"
         >
           <v-list-item-icon>
             <v-icon>mdi-cog</v-icon>
           </v-list-item-icon>
           <v-list-item-content>
             <v-list-item-title>Settings</v-list-item-title>
           </v-list-item-content>
         </v-list-item>
       </v-list>
     </v-navigation-drawer>

      <router-view/>
    </v-app>

  </div>
</template>
<script lang="ts">
import Vue from 'vue'
import { ipcRenderer as ipc } from 'electron'

export default Vue.extend({
  name: 'Home',
  data () {
    return {
      items: [
        {
          title: 'nginx',
          icon: 'mdi-web',
          path: 'settings/nginx'
        },
        {
          title: 'php',
          icon: 'mdi-language-php',
          path: 'settings/php'

        },
        {
          title: 'database',
          icon: 'mdi-database',
          path: 'settings/mysql'
        }
      ],
      drawer: true
    }
  },
  created () {

      ipc.on('GETCONFIG',)
  },
  methods: {
    minimiseApp () {
      ipc.send('MINIMISE', '')
    },
    maximiseApp () {
      ipc.send('MAXIMISE', '')
    },
    closeApp () {
      ipc.send('CLOSE_APP', '')
    }
  }
})
</script>
<style>
.moveWindow {
  -webkit-app-region: drag;
}

.WindowBarBtn {
  -webkit-app-region: no-drag;

}
body{
  overflow-x: hidden;
}
::-webkit-scrollbar {
  display: none;
}
.sidebar{
  background: #f87dba;
  width: 20rem;
}
</style>
