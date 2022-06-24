using UnityEngine;

using Game.Base.MVC;
using Game.Module.SaveData;

namespace Game.Module.HighScore
{
    public class HighScoreCounterController : GameDataController<HighScoreCounterController, HighScoreCounterModel, IHighScoreModel>
    {
        private SaveDataController _saveData;
        public void CheckHighScore(int score)
        {
            if (score > _model.HighScore)
            {
                _model.SetHighScore(score);
                _saveData.Save(_model.HighScore);
            }
        }

        public void LoadHighScore()
        {
            _model.SetHighScore(_saveData.Model.HighScoreData);
        }
    }
}
