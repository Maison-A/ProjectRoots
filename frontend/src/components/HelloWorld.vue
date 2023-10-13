<template lang="pug">
div    
   ul
     li(v-for="user in users" :key="user.id") {{ user.UserName }}
</template>

<script>
import axios from "axios";

export default {
  data() {
    return {
      users: [],
    };
  },
  mounted() {
    axios
      .get("http://localhost:7103/GetUsers")
      .then((response) => {
        this.users = response.data;
      })
      .catch((error) => {
        console.error("There was an error:", error);
      });
  },
};
</script>
