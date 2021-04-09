import {View, Text, StyleSheet } from 'react-native';
import React from 'react';


const Header = () =>{
  return (
    <View style={estiloHeader.container}>
      <Text>Saldo</Text>
    </View>
  )
}

export default Header

const estiloHeader = new StyleSheet.create({
  container: {
    flex: 2,
    flexDirection: 'row',
    backgroundColor: 'red'
  }
});