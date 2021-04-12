import React from 'react'
import {StyleSheet,
        Text,
        View
      } from 'react-native';
import ListCoin from './ListCoin';

const styles = StyleSheet.create({
  display:{
    flex:1,
    padding: 20,
    backgroundColor: '#506AD4',
  },
  displayValue: {
    fontSize: 45,
    color:'#fff',
    flex: 1,
    marginLeft: 200
  }
})

export default props =>{
  return(
  <View style={styles.display}>
  
    <Text style={styles.displayValue}
    numberOfLines={1}>
    <ListCoin />{props.coin} : {props.value}
    </Text>
    
  </View>
  )
}