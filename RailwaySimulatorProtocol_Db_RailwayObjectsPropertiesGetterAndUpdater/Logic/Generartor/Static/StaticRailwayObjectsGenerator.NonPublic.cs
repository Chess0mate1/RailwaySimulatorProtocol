using System;
using System.Collections.Generic;

using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects;
using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Interface.RailwayObjects.Static;
using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Converter.Static;
using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.DataReader.Text;
using RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Line;

namespace RailwaySimulatorProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Generartor.Static
{
    internal partial class StaticRailwayObjectsGenerator
    {
        private readonly List<Vertex> _vertices = new();
        private readonly List<Rail> _rails = new();
        private readonly List<Switch> _switches = new();
        private readonly List<Semaphore> _semaphores = new();
        private readonly List<Retarder> _retarders = new();

        private LineElements _lineElements = new();
        private RailwayObjectType _type;

        protected override TxtFileDataReader Reader { get; } = new();

        protected override void SetRailwayObjects()
        {
            while (IsNotEndFile())
            {
                DefineRailwayObjectType();

                AddFirstObject();

                AddRemainingObjects();
            }
        }



        private bool IsNotEndFile()
        {
            return _lineElements is not null;
        }


        private void DefineRailwayObjectType()
        {
            while (TryReadLine())
            {
                if (IsLineNotEmpty() && TrySetRailwayObjectType())
                {
                    return;
                }
            }

            throw new Exception("Структура файла изменилась. " +
                                "Проверьте наличие всех заголовков: \n" +
                                "'vertices', 'rails', 'switches', 'semaphores', 'retarders' ");
        }

        private bool TrySetRailwayObjectType()
        {
            var type = GetPossibleType(_lineElements[0]);

            if (IsRailwayObjectType(type))
            {
                _type = (RailwayObjectType)type;
                return true;
            }

            return false;
        }
        private RailwayObjectType? GetPossibleType(string defineTypeElement)
            => defineTypeElement switch
            {
                "vertices" => RailwayObjectType.Vertix,
                "rails" => RailwayObjectType.Rail,
                "switches" => RailwayObjectType.Switch,
                "semaphores" => RailwayObjectType.Semaphore,
                "retarders" => RailwayObjectType.Retarder,
                _ => null
            };
        private bool IsRailwayObjectType(RailwayObjectType? type)
            => type is not null;


        private void AddFirstObject()
        {
            while (TryReadLine())
            {
                if (IsLineNotEmpty() && IsLineOfValuesStarts())
                {
                    AddElement(_type);
                    break;
                }
            }
        }


        private void AddRemainingObjects()
        {
            while (TryReadLine() && IsLineNotEmpty())
            {
                AddElement(_type);
            }
        }


        private bool TryReadLine()
            => (_lineElements = Reader.ReadLine()) is not null;

        private bool IsLineOfValuesStarts()
            => _lineElements[0] == "0";

        private bool IsLineEmpty()
            => _lineElements.Length == 0;

        private bool IsLineNotEmpty()
            => !IsLineEmpty();

        private void AddElement(RailwayObjectType railwayObject)
        {
            switch (railwayObject)
            {
                case RailwayObjectType.Vertix:
                    VertexConverter vertexConverter = new();
                    _vertices.Add(vertexConverter.GetObjectFrom(_lineElements));
                    break;
                case RailwayObjectType.Rail:
                    RailConverter railConverter = new();
                    _rails.Add(railConverter.GetObjectFrom(_lineElements));
                    break;
                case RailwayObjectType.Switch:
                    SwitchConverter switchConverter = new();
                    _switches.Add(switchConverter.GetObjectFrom(_lineElements));
                    SkipUnnecessaryLines(3);
                    break;
                case RailwayObjectType.Semaphore:
                    SemaphoreConverter semaphoreConverter = new();
                    _semaphores.Add(semaphoreConverter.GetObjectFrom(_lineElements));
                    break;
                case RailwayObjectType.Retarder:
                    RetarderConverter retarderConverter = new();
                    _retarders.Add(retarderConverter.GetObjectFrom(_lineElements));
                    break;
            };
        }
        private void SkipUnnecessaryLines(int time)
        {
            for (int i = 0; i < time; i++)
                Reader.ReadLine();
        }
    }
}
