import {View, Text, StyleSheet } from 'react-native';
import React from 'react';


const Header = (props) =>{
  const estiloHeader = new StyleSheet.create({
    container: {
      flexDirection: 'row',
      width: '100%',
      height: '5%'
    },
    textSaldo: {
      color: '#ccc',
      fontSize: 20,
      backgroundColor: props.cor,
      width: '100%',
    }
  });
  
  return (
    <View style={estiloHeader.container}>
      <Text style={estiloHeader.textSaldo}>{props.value} </Text>
      <Text>1000</Text>
    </View>
  )
}

export default Header

