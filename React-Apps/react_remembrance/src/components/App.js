import React from 'react';
import Header from './Header'
import Image from './ImageList'

// LOGIC 
// 1. Keep Tabs of Score
// 2. Restart Game Condition

// TO-DO : Conditionally restart the game
class App extends React.Component {
  state = { score: 0 };
  array = ['a', 'b', 'c', 'd', 'e', 'f']

  handleScoreIncrement = (e) => {
    this.setState({ score: this.state.score + 1 })
    console.log(this.state.score)
  }

  handleRestart = () => {
    this.setState({ score: 0 })
  }

  render() {

    return (

      <div>
        <Header score={this.state.score} />
        <div className='ui container'>
          <div className='ui segment'>
            <div className='ui four column grid'>

              {[...this.array].map((cv, i, arr) => {
                return (
                  <Image
                    key={i}
                    content={cv}
                    score={this.state.score}
                    increaseScore={this.handleScoreIncrement}
                    restart={this.handleRestart}
                  />

                )
              })
              }
            </div>
          </div>
        </div>

      </div>
    )

  }
};


export default App; 