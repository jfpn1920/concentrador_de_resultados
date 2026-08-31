Imports System
Module concentrador_de_resultados
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim participantes(9) As String
        Dim actividades(9) As String
        Dim resultados1(9) As Double
        Dim resultados2(9) As Double
        Dim resultados3(9) As Double
        Dim promedios(9) As Double
        Dim estados(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '-----------------------------------------------'
        '--|menu_principal_concentrador_de_resultados|--'
        '-----------------------------------------------'
        Do
            Console.WriteLine("menu principal concentrador de resultados")
            Console.WriteLine("1) Registrar resultado")
            Console.WriteLine("2) Editar resultado")
            Console.WriteLine("3) Listar resultados")
            Console.WriteLine("4) Buscar resultado")
            Console.WriteLine("5) Eliminar resultado")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion

                '-------------------------'
                '--|registrar_resultado|--'
                '-------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas resultados.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Nombre del participante: ")
                        participantes(cantidad) = Console.ReadLine()
                        Console.Write("Actividad: ")
                        actividades(cantidad) = Console.ReadLine()
                        Console.Write("Resultado 1: ")
                        resultados1(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Resultado 2: ")
                        resultados2(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Resultado 3: ")
                        resultados3(cantidad) = Convert.ToDouble(Console.ReadLine())
                        promedios(cantidad) = (resultados1(cantidad) + resultados2(cantidad) + resultados3(cantidad)) / 3
                        If promedios(cantidad) >= 60 Then
                            estados(cantidad) = "Aprobado"
                        Else
                            estados(cantidad) = "Reprobado"
                        End If
                        cantidad += 1
                        Console.WriteLine("Resultado registrado correctamente.")
                        Console.WriteLine("ID: " & ids(cantidad - 1) & " | Participante: " & participantes(cantidad - 1) & " | Actividad: " & actividades(cantidad - 1) & " | Resultado 1: " & resultados1(cantidad - 1) & " | Resultado 2: " & resultados2(cantidad - 1) & " | Resultado 3: " & resultados3(cantidad - 1) & " | Promedio: " & promedios(cantidad - 1) & " | Estado: " & estados(cantidad - 1))
                    End If
                '----------------------'
                '--|editar_resultado|--'
                '----------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen resultados registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Participante: " & participantes(i) & " | Actividad: " & actividades(i) & " | Resultado 1: " & resultados1(i) & " | Resultado 2: " & resultados2(i) & " | Resultado 3: " & resultados3(i) & " | Promedio: " & promedios(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID del resultado a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo participante: ")
                            participantes(posicion) = Console.ReadLine()
                            Console.Write("Nueva actividad: ")
                            actividades(posicion) = Console.ReadLine()
                            Console.Write("Nuevo resultado 1: ")
                            resultados1(posicion) = Convert.ToDouble(Console.ReadLine())
                            Console.Write("Nuevo resultado 2: ")
                            resultados2(posicion) = Convert.ToDouble(Console.ReadLine())
                            Console.Write("Nuevo resultado 3: ")
                            resultados3(posicion) = Convert.ToDouble(Console.ReadLine())
                            promedios(posicion) = (resultados1(posicion) + resultados2(posicion) + resultados3(posicion)) / 3
                            If promedios(posicion) >= 60 Then
                                estados(posicion) = "Aprobado"
                            Else
                                estados(posicion) = "Reprobado"
                            End If
                            Console.WriteLine("Resultado actualizado correctamente.")
                            Console.WriteLine("ID: " & ids(posicion) & " | Participante: " & participantes(posicion) & " | Actividad: " & actividades(posicion) & " | Resultado 1: " & resultados1(posicion) & " | Resultado 2: " & resultados2(posicion) & " | Resultado 3: " & resultados3(posicion) & " | Promedio: " & promedios(posicion) & " | Estado: " & estados(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-----------------------'
                '--|listar_resultados|--'
                '-----------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen resultados registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Participante: " & participantes(i) & " | Actividad: " & actividades(i) & " | Resultado 1: " & resultados1(i) & " | Resultado 2: " & resultados2(i) & " | Resultado 3: " & resultados3(i) & " | Promedio: " & promedios(i) & " | Estado: " & estados(i))
                        Next
                    End If
                '----------------------'
                '--|buscar_resultado|--'
                '----------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen resultados registrados.")
                    Else
                        Console.WriteLine("1) Buscar por ID")
                        Console.WriteLine("2) Buscar por participante")
                        Console.WriteLine("3) Buscar por actividad")
                        Console.Write("Seleccione una opcion: ")
                        Dim tipoBusqueda As Integer = Convert.ToInt32(Console.ReadLine())
                        If tipoBusqueda = 1 Then
                            Console.Write("Ingrese el ID del resultado a buscar: ")
                            Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                            If idBuscar >= 1 And idBuscar <= cantidad Then
                                Dim posicion As Integer = idBuscar - 1
                                Console.WriteLine("ID: " & ids(posicion) & " | Participante: " & participantes(posicion) & " | Actividad: " & actividades(posicion) & " | Resultado 1: " & resultados1(posicion) & " | Resultado 2: " & resultados2(posicion) & " | Resultado 3: " & resultados3(posicion) & " | Promedio: " & promedios(posicion) & " | Estado: " & estados(posicion))
                            Else
                                Console.WriteLine("ID no encontrada.")
                            End If
                        ElseIf tipoBusqueda = 2 Then
                            Console.Write("Ingrese el nombre del participante: ")
                            Dim participanteBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If participantes(i).ToLower() = participanteBuscar.ToLower() Then
                                    Console.WriteLine("ID: " & ids(i) & " | Participante: " & participantes(i) & " | Actividad: " & actividades(i) & " | Resultado 1: " & resultados1(i) & " | Resultado 2: " & resultados2(i) & " | Resultado 3: " & resultados3(i) & " | Promedio: " & promedios(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron resultados para ese participante.")
                            End If
                        ElseIf tipoBusqueda = 3 Then
                            Console.Write("Ingrese el nombre de la actividad: ")
                            Dim actividadBuscar As String = Console.ReadLine()
                            Dim encontrado As Boolean = False
                            For i As Integer = 0 To cantidad - 1
                                If actividades(i).ToLower() = actividadBuscar.ToLower() Then
                                    Console.WriteLine("ID: " & ids(i) & " | Participante: " & participantes(i) & " | Actividad: " & actividades(i) & " | Resultado 1: " & resultados1(i) & " | Resultado 2: " & resultados2(i) & " | Resultado 3: " & resultados3(i) & " | Promedio: " & promedios(i) & " | Estado: " & estados(i))
                                    encontrado = True
                                End If
                            Next
                            If Not encontrado Then
                                Console.WriteLine("No se encontraron resultados para esa actividad.")
                            End If
                        Else
                            Console.WriteLine("Opcion no valida.")
                        End If
                    End If
                '------------------------'
                '--|eliminar_resultado|--'
                '------------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen resultados registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Participante: " & participantes(i) & " | Actividad: " & actividades(i) & " | Resultado 1: " & resultados1(i) & " | Resultado 2: " & resultados2(i) & " | Resultado 3: " & resultados3(i) & " | Promedio: " & promedios(i) & " | Estado: " & estados(i))
                        Next
                        Console.Write("Ingrese el ID del resultado a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                participantes(i) = participantes(i + 1)
                                actividades(i) = actividades(i + 1)
                                resultados1(i) = resultados1(i + 1)
                                resultados2(i) = resultados2(i + 1)
                                resultados3(i) = resultados3(i + 1)
                                promedios(i) = promedios(i + 1)
                                estados(i) = estados(i + 1)
                            Next
                            cantidad -= 1
                            ids(cantidad) = 0
                            participantes(cantidad) = ""
                            actividades(cantidad) = ""
                            resultados1(cantidad) = 0
                            resultados2(cantidad) = 0
                            resultados3(cantidad) = 0
                            promedios(cantidad) = 0
                            estados(cantidad) = ""
                            For i As Integer = 0 To cantidad - 1
                                ids(i) = i + 1
                            Next
                            Console.WriteLine("Resultado eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen resultados registrados.")
                    Else
                        Dim aprobados As Integer = 0
                        Dim reprobados As Integer = 0
                        Dim sumaPromedios As Double = 0
                        Dim promedioMayor As Double = promedios(0)
                        Dim promedioMenor As Double = promedios(0)
                        Dim participanteMayor As String = participantes(0)
                        Dim participanteMenor As String = participantes(0)
                        For i As Integer = 0 To cantidad - 1
                            sumaPromedios += promedios(i)
                            If estados(i) = "Aprobado" Then
                                aprobados += 1
                            ElseIf estados(i) = "Reprobado" Then
                                reprobados += 1
                            End If
                            If promedios(i) > promedioMayor Then
                                promedioMayor = promedios(i)
                                participanteMayor = participantes(i)
                            End If
                            If promedios(i) < promedioMenor Then
                                promedioMenor = promedios(i)
                                participanteMenor = participantes(i)
                            End If
                        Next
                        Dim promedioGeneral As Double = sumaPromedios / cantidad
                        Console.WriteLine("Resultados: " & cantidad & " | Aprobados: " & aprobados & " | Reprobados: " & reprobados & " | Promedio general: " & promedioGeneral & " | Promedio mayor: " & promedioMayor & " (" & participanteMayor & ")" & " | Promedio menor: " & promedioMenor & " (" & participanteMenor & ")")
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Concentrador de Resultados.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module