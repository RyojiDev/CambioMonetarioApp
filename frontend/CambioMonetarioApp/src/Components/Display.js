import React, {useContext} from 'react'
import {StyleSheet,
        Text,
        View
      } from 'react-native';
import ListCoin from './ListCoin';

import CurrencyContext from '../context/CurrencyContext';


const styles = StyleSheet.create({
  display:{
    flex:1,
    padding: 20,
    backgroundColor: props.cor ? props.cor : '#506AD4',
  },
  displayValue: {
    fontSize: 45,
    color:'#fff',
    flex: 1,
    marginLeft: 200
  }
})

export default props =>{
  const {state,dispatch} = useContext(CurrencyContext);
  console.log(state, "bem aqui")
  return(
  <View style={styles.display}>
  
    <Text style={styles.displayValue}
    numberOfLines={1}>
    <ListCoin />{props.coin} : {state.display.value}
    </Text>
    
  </View>
  )
}