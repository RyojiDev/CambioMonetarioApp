import React, {createContext, useReducer} from 'react';

const CurrencyContext = createContext({})
export const CurrencyProviders = props => {

  const initialState = {
    display: [{value: 0,
    clearDisplay : false
    }],
    operation: null,
    values: [0,0],
    current: 0,
    currency: []
  }

  const actions = {
    mudarDisplay(state, action){
      console.log(action.payload, "essa aqui")
      const display = action.payload
      return {
        ...state,
        display: [...state.display, display]
      }
    },
    retornarLista(state,action){
      console.log(action,"recebo a lista")
    }
  }


function reducer(state, action){
 // console.warn(action)
  const fn = actions[action.type]
  return fn ? fn(state, action) : state
}

const [state, dispatch] = useReducer(reducer, initialState);

  return (
    <CurrencyContext.Provider value={{
      state, dispatch
    }}>
     {props.children}
    </CurrencyContext.Provider>
  )
}

export default CurrencyContext;